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

        SqlConnection connection = new SqlConnection();
        private static string ConnectionString;

        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            ConnectionString = "Data Source=" + txt_dbSource.Text + ";Initial Catalog=" + txt_dbDatabase.Text + ";User ID=" + txt_dbUser.Text + ";Password=" + txt_dbPassword.Text;
            SqlDependency.Start(ConnectionString);
            SqlDependencyWatch();
            RefreshTable();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            SqlDependency.Stop(ConnectionString);
        }


        //this.Invoke((EventHandler)(delegate { dataGridView1.DataSource = m; }));
        private void SqlDependencyWatch() {
            //string sSQL = "select name,age from [dbo].[People]";

            string sSQL = "SELECT is_current_owner FROM [AMRZS_20170726].[sys].[dm_os_cluster_nodes]";

            //string TT = "select LastName from dbo.Persons";

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

        private void RefreshTable() {
            string sSQL22 = "SELECT Nodename,status,is_current_owner FROM [AMRZS_20170726].[sys].[dm_os_cluster_nodes]";

            string TT = "select LastName from dbo.Persons";

            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(TT, connection)) {
                    using (SqlDataAdapter dr = new SqlDataAdapter(TT, connection)) {
                        dr.Fill(datatable);
                        this.Invoke((EventHandler)(delegate { dataGridView1.DataSource = datatable; }));
                    }
                }
            }
        }

        void SQLTableOnChange(object sender, SqlNotificationEventArgs e) {       
            SqlDependencyWatch();
            RefreshTable();
        }
    }
}
