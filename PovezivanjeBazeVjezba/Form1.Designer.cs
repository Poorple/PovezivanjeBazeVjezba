
namespace PovezivanjeBazeVjezba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DDValue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBaze = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Fetch = new System.Windows.Forms.Button();
            this.SqlDataGridView = new System.Windows.Forms.DataGridView();
            this.UpSpendLim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LowSpendLim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.YofInvoice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CityFetch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SqlDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DDValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtBaze);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // DDValue
            // 
            this.DDValue.FormattingEnabled = true;
            this.DDValue.Items.AddRange(new object[] {
            "Windows Auth",
            "SQL Auth"});
            this.DDValue.Location = new System.Drawing.Point(7, 37);
            this.DDValue.Name = "DDValue";
            this.DDValue.Size = new System.Drawing.Size(280, 21);
            this.DDValue.TabIndex = 10;
            this.DDValue.SelectedIndexChanged += new System.EventHandler(this.DDValue_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Connection Type";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(5, 239);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(282, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Baze123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passsword";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 197);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 284);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBaze
            // 
            this.txtBaze.Location = new System.Drawing.Point(6, 153);
            this.txtBaze.Name = "txtBaze";
            this.txtBaze.Size = new System.Drawing.Size(281, 20);
            this.txtBaze.TabIndex = 3;
            this.txtBaze.Text = "SimpleWebShop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database name";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(6, 109);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(281, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "DESKTOP-6NMLSK2\\MSSQLSERVERUNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YofInvoice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LowSpendLim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.UpSpendLim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Fetch);
            this.groupBox2.Location = new System.Drawing.Point(13, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buyer information";
            // 
            // Fetch
            // 
            this.Fetch.Location = new System.Drawing.Point(211, 140);
            this.Fetch.Name = "Fetch";
            this.Fetch.Size = new System.Drawing.Size(75, 23);
            this.Fetch.TabIndex = 0;
            this.Fetch.Text = "Fetch";
            this.Fetch.UseVisualStyleBackColor = true;
            this.Fetch.Click += new System.EventHandler(this.Fetch_Click);
            // 
            // SqlDataGridView
            // 
            this.SqlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SqlDataGridView.Location = new System.Drawing.Point(319, 17);
            this.SqlDataGridView.Name = "SqlDataGridView";
            this.SqlDataGridView.Size = new System.Drawing.Size(1391, 687);
            this.SqlDataGridView.TabIndex = 2;
            // 
            // UpSpendLim
            // 
            this.UpSpendLim.Location = new System.Drawing.Point(6, 75);
            this.UpSpendLim.Name = "UpSpendLim";
            this.UpSpendLim.Size = new System.Drawing.Size(281, 20);
            this.UpSpendLim.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Upper spending limit";
            // 
            // LowSpendLim
            // 
            this.LowSpendLim.Location = new System.Drawing.Point(6, 36);
            this.LowSpendLim.Name = "LowSpendLim";
            this.LowSpendLim.Size = new System.Drawing.Size(281, 20);
            this.LowSpendLim.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lower spending limit";
            // 
            // YofInvoice
            // 
            this.YofInvoice.Location = new System.Drawing.Point(7, 114);
            this.YofInvoice.Name = "YofInvoice";
            this.YofInvoice.Size = new System.Drawing.Size(281, 20);
            this.YofInvoice.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Year of issuing the invoice";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInsert);
            this.groupBox3.Controls.Add(this.txtCityName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CityFetch);
            this.groupBox3.Location = new System.Drawing.Point(13, 523);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 97);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "City Information";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(6, 36);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(281, 20);
            this.txtCityName.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "City name";
            // 
            // CityFetch
            // 
            this.CityFetch.Location = new System.Drawing.Point(9, 62);
            this.CityFetch.Name = "CityFetch";
            this.CityFetch.Size = new System.Drawing.Size(75, 23);
            this.CityFetch.TabIndex = 0;
            this.CityFetch.Text = "Fetch Cities";
            this.CityFetch.UseVisualStyleBackColor = true;
            this.CityFetch.Click += new System.EventHandler(this.CityFetch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(211, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert City";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 848);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SqlDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lab. Vjezba";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SqlDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBaze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DDValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Fetch;
        private System.Windows.Forms.DataGridView SqlDataGridView;
        private System.Windows.Forms.TextBox LowSpendLim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpSpendLim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YofInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CityFetch;
        private System.Windows.Forms.Button btnInsert;
    }
}

