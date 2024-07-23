namespace StockYearly.PL
{
    partial class FrmServeurConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServeurConnexion));
            this.btn_ConnexionServeur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBlankPassAllowed = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkUseWindowsSecurity = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindServers = new System.Windows.Forms.Button();
            this.cmbServers = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ConnexionServeur
            // 
            this.btn_ConnexionServeur.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConnexionServeur.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConnexionServeur.Image")));
            this.btn_ConnexionServeur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ConnexionServeur.Location = new System.Drawing.Point(12, 10);
            this.btn_ConnexionServeur.Name = "btn_ConnexionServeur";
            this.btn_ConnexionServeur.Size = new System.Drawing.Size(119, 32);
            this.btn_ConnexionServeur.TabIndex = 1037;
            this.btn_ConnexionServeur.Text = "Connéxion";
            this.btn_ConnexionServeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConnexionServeur.UseVisualStyleBackColor = true;
            this.btn_ConnexionServeur.Click += new System.EventHandler(this.btn_ConnexionServeur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBlankPassAllowed);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.chkUseWindowsSecurity);
            this.groupBox2.Location = new System.Drawing.Point(22, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 140);
            this.groupBox2.TabIndex = 1040;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Windows Security";
            // 
            // chkBlankPassAllowed
            // 
            this.chkBlankPassAllowed.AutoSize = true;
            this.chkBlankPassAllowed.Location = new System.Drawing.Point(7, 76);
            this.chkBlankPassAllowed.Name = "chkBlankPassAllowed";
            this.chkBlankPassAllowed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBlankPassAllowed.Size = new System.Drawing.Size(142, 17);
            this.chkBlankPassAllowed.TabIndex = 9;
            this.chkBlankPassAllowed.Text = "Blank Password Allowed";
            this.chkBlankPassAllowed.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 102);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(84, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "User Name";
            // 
            // chkUseWindowsSecurity
            // 
            this.chkUseWindowsSecurity.AutoSize = true;
            this.chkUseWindowsSecurity.Checked = true;
            this.chkUseWindowsSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseWindowsSecurity.Location = new System.Drawing.Point(6, 27);
            this.chkUseWindowsSecurity.Name = "chkUseWindowsSecurity";
            this.chkUseWindowsSecurity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseWindowsSecurity.Size = new System.Drawing.Size(133, 17);
            this.chkUseWindowsSecurity.TabIndex = 6;
            this.chkUseWindowsSecurity.Text = "Use Windows Security";
            this.chkUseWindowsSecurity.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Teal;
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Controls.Add(this.btn_ConnexionServeur);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 412);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(328, 54);
            this.Panel2.TabIndex = 1038;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Location = new System.Drawing.Point(215, 10);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(106, 32);
            this.Button1.TabIndex = 1038;
            this.Button1.Text = "Annuler   ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindServers);
            this.groupBox1.Controls.Add(this.cmbServers);
            this.groupBox1.Location = new System.Drawing.Point(22, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(285, 62);
            this.groupBox1.TabIndex = 1039;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select SQL Server";
            // 
            // btnFindServers
            // 
            this.btnFindServers.Location = new System.Drawing.Point(230, 22);
            this.btnFindServers.Name = "btnFindServers";
            this.btnFindServers.Size = new System.Drawing.Size(35, 23);
            this.btnFindServers.TabIndex = 1;
            this.btnFindServers.Text = "...";
            this.btnFindServers.UseVisualStyleBackColor = true;
            this.btnFindServers.Click += new System.EventHandler(this.btnFindServers_Click);
            // 
            // cmbServers
            // 
            this.cmbServers.FormattingEnabled = true;
            this.cmbServers.Location = new System.Drawing.Point(17, 24);
            this.cmbServers.Name = "cmbServers";
            this.cmbServers.Size = new System.Drawing.Size(207, 21);
            this.cmbServers.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 81);
            this.panel3.TabIndex = 1041;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "CONNEXION AU SERVEUR";
            // 
            // FrmServeurConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmServeurConnexion";
            this.Text = "FrmServeurConnexion";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ConnexionServeur;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.CheckBox chkBlankPassAllowed;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkUseWindowsSecurity;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindServers;
        private System.Windows.Forms.ComboBox cmbServers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}