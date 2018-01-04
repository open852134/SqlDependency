using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SqlDependency_Test {
    public partial class Form1 : Form {

        /* 確認DB有執行 [alter database <dbname> set enable_broker with rollback immediate;] */

        SqlConnection connection = new SqlConnection();
        private static string ConnectionString;

        public Form1() {
            InitializeComponent();
        }


        /* 啟動SQL監控 */
        private void btn_Start_Click(object sender, EventArgs e) {
            try {
                ConnectionString = "Data Source=" + txt_dbSource.Text + ";Initial Catalog=" + txt_dbDatabase.Text + ";User ID=" + txt_dbUser.Text + ";Password=" + txt_dbPassword.Text;
                SqlDependency.Start(ConnectionString);
                SqlDependencyWatch();
                RefreshTable();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }


        /* 關閉SQL監控 */
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            SqlDependency.Stop(ConnectionString);
        }
        private void btn_Stop_Click(object sender, EventArgs e) {
            SqlDependency.Stop(ConnectionString);
        }



        /* 建立SQL監控 */
        private void SqlDependencyWatch() {

            string sSQL = "SELECT id,errcode,errtext FROM [dbo].[alarm]";

            using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                using (SqlCommand command = new SqlCommand(sSQL, connection)) {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(SQLTableOnChange);
                    SqlDataReader sdr = command.ExecuteReader();
                }
            }
        }

        /* 資料表修改觸發Event事件處理 */
        void SQLTableOnChange(object sender, SqlNotificationEventArgs e) {
            SqlDependencyWatch();
            RefreshTable();
        }


        /* 重新更新DataGridView顯示資料 */
        private void RefreshTable() {
            string sSQL = "SELECT * FROM alarm";

            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sSQL, connection)) {
                    using (SqlDataAdapter dr = new SqlDataAdapter(sSQL, connection)) {
                        dr.Fill(datatable);
                        this.Invoke((EventHandler)(delegate { dataGridView1.DataSource = datatable; }));
                    }
                }
            }
        }


    }
}
