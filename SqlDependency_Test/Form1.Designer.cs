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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dbSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dbUser = new System.Windows.Forms.TextBox();
            this.txt_dbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dbDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datasource";
            // 
            // txt_dbSource
            // 
            this.txt_dbSource.Location = new System.Drawing.Point(73, 12);
            this.txt_dbSource.Name = "txt_dbSource";
            this.txt_dbSource.Size = new System.Drawing.Size(117, 22);
            this.txt_dbSource.TabIndex = 3;
            this.txt_dbSource.Text = "172.16.12.229";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // txt_dbUser
            // 
            this.txt_dbUser.Location = new System.Drawing.Point(373, 12);
            this.txt_dbUser.Name = "txt_dbUser";
            this.txt_dbUser.Size = new System.Drawing.Size(112, 22);
            this.txt_dbUser.TabIndex = 5;
            this.txt_dbUser.Text = "sa";
            // 
            // txt_dbPassword
            // 
            this.txt_dbPassword.Location = new System.Drawing.Point(543, 12);
            this.txt_dbPassword.Name = "txt_dbPassword";
            this.txt_dbPassword.Size = new System.Drawing.Size(112, 22);
            this.txt_dbPassword.TabIndex = 7;
            this.txt_dbPassword.Text = "CGMH_8888";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txt_dbDatabase
            // 
            this.txt_dbDatabase.Location = new System.Drawing.Point(223, 12);
            this.txt_dbDatabase.Name = "txt_dbDatabase";
            this.txt_dbDatabase.Size = new System.Drawing.Size(112, 22);
            this.txt_dbDatabase.TabIndex = 9;
            this.txt_dbDatabase.Text = "AMRZS_20170726";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "DB";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Start Watch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 22);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 378);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_dbDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dbSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

