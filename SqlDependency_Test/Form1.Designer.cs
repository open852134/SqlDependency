namespace SqlDependency_Test {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dbSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dbUser = new System.Windows.Forms.TextBox();
            this.txt_dbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dbDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datasource";
            // 
            // txt_dbSource
            // 
            this.txt_dbSource.Location = new System.Drawing.Point(85, 16);
            this.txt_dbSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dbSource.Name = "txt_dbSource";
            this.txt_dbSource.Size = new System.Drawing.Size(150, 23);
            this.txt_dbSource.TabIndex = 3;
            this.txt_dbSource.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // txt_dbUser
            // 
            this.txt_dbUser.Location = new System.Drawing.Point(85, 47);
            this.txt_dbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dbUser.Name = "txt_dbUser";
            this.txt_dbUser.Size = new System.Drawing.Size(150, 23);
            this.txt_dbUser.TabIndex = 5;
            this.txt_dbUser.Text = "sa";
            // 
            // txt_dbPassword
            // 
            this.txt_dbPassword.Location = new System.Drawing.Point(304, 47);
            this.txt_dbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dbPassword.Name = "txt_dbPassword";
            this.txt_dbPassword.PasswordChar = '*';
            this.txt_dbPassword.Size = new System.Drawing.Size(150, 23);
            this.txt_dbPassword.TabIndex = 7;
            this.txt_dbPassword.Text = "passw0rd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txt_dbDatabase
            // 
            this.txt_dbDatabase.Location = new System.Drawing.Point(304, 16);
            this.txt_dbDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dbDatabase.Name = "txt_dbDatabase";
            this.txt_dbDatabase.Size = new System.Drawing.Size(150, 23);
            this.txt_dbDatabase.TabIndex = 9;
            this.txt_dbDatabase.Text = "SqlDependency_TDB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "DB";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(473, 47);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(108, 23);
            this.btn_Stop.TabIndex = 11;
            this.btn_Stop.Text = "Stop Watch";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Start.Location = new System.Drawing.Point(473, 16);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(108, 23);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "Start Watch";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 420);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.txt_dbDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dbSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dbSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dbUser;
        private System.Windows.Forms.TextBox txt_dbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dbDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
    }
}

