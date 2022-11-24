namespace MegaVox.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel_log = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_usrname = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.panel_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_log
            // 
            this.panel_log.Controls.Add(this.lblLogin);
            this.panel_log.Controls.Add(this.button_login);
            this.panel_log.Controls.Add(this.textBox_usrname);
            this.panel_log.Controls.Add(this.textBox_password);
            this.panel_log.Controls.Add(this.label_Password);
            this.panel_log.Controls.Add(this.label_userName);
            this.panel_log.Location = new System.Drawing.Point(69, 60);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(678, 341);
            this.panel_log.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Coral;
            this.lblLogin.Location = new System.Drawing.Point(185, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(302, 55);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Please Login";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Transparent;
            this.button_login.Location = new System.Drawing.Point(174, 260);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(325, 41);
            this.button_login.TabIndex = 14;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_usrname
            // 
            this.textBox_usrname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_usrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usrname.Location = new System.Drawing.Point(174, 137);
            this.textBox_usrname.Name = "textBox_usrname";
            this.textBox_usrname.Size = new System.Drawing.Size(325, 26);
            this.textBox_usrname.TabIndex = 12;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(174, 203);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(325, 26);
            this.textBox_password.TabIndex = 13;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.label_Password.Location = new System.Drawing.Point(170, 179);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 20);
            this.label_Password.TabIndex = 10;
            this.label_Password.Text = "Password :";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.label_userName.Location = new System.Drawing.Point(170, 113);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(97, 20);
            this.label_userName.TabIndex = 11;
            this.label_userName.Text = "User Name :";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_log);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_usrname;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label lblLogin;
    }
}