namespace MegaVox.GUI
{
    partial class frmCreateUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            this.btn_New = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GrdUser = new System.Windows.Forms.DataGridView();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.grpCreateUser = new System.Windows.Forms.GroupBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUser)).BeginInit();
            this.Panel1.SuspendLayout();
            this.grpCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_New.Location = new System.Drawing.Point(589, 217);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(176, 32);
            this.btn_New.TabIndex = 31;
            this.btn_New.Text = "New";
            this.ToolTip1.SetToolTip(this.btn_New, "New");
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(773, 218);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 32);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.ToolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saveuser.Location = new System.Drawing.Point(31, 219);
            this.btn_saveuser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(184, 32);
            this.btn_saveuser.TabIndex = 29;
            this.btn_saveuser.Text = "Save";
            this.ToolTip1.SetToolTip(this.btn_saveuser, "Save Data");
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(223, 218);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(184, 32);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Update";
            this.ToolTip1.SetToolTip(this.btn_update, "Update");
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Location = new System.Drawing.Point(415, 217);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(167, 32);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.GrdUser);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.Location = new System.Drawing.Point(0, 257);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1004, 382);
            this.GroupBox1.TabIndex = 33;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "List Of Users";
            // 
            // GrdUser
            // 
            this.GrdUser.AllowUserToAddRows = false;
            this.GrdUser.AllowUserToDeleteRows = false;
            this.GrdUser.AllowUserToResizeColumns = false;
            this.GrdUser.AllowUserToResizeRows = false;
            this.GrdUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdUser.Location = new System.Drawing.Point(4, 19);
            this.GrdUser.Margin = new System.Windows.Forms.Padding(4);
            this.GrdUser.Name = "GrdUser";
            this.GrdUser.RowHeadersVisible = false;
            this.GrdUser.RowHeadersWidth = 51;
            this.GrdUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdUser.Size = new System.Drawing.Size(996, 359);
            this.GrdUser.TabIndex = 0;
            this.GrdUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUser_CellContentClick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.grpCreateUser);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1004, 210);
            this.Panel1.TabIndex = 34;
            // 
            // grpCreateUser
            // 
            this.grpCreateUser.Controls.Add(this.txtUserId);
            this.grpCreateUser.Controls.Add(this.label1);
            this.grpCreateUser.Controls.Add(this.cboType);
            this.grpCreateUser.Controls.Add(this.lblUserId);
            this.grpCreateUser.Controls.Add(this.txtPassword);
            this.grpCreateUser.Controls.Add(this.label6);
            this.grpCreateUser.Controls.Add(this.label7);
            this.grpCreateUser.Controls.Add(this.txtUserName);
            this.grpCreateUser.Controls.Add(this.label8);
            this.grpCreateUser.Location = new System.Drawing.Point(12, 12);
            this.grpCreateUser.Name = "grpCreateUser";
            this.grpCreateUser.Size = new System.Drawing.Size(979, 181);
            this.grpCreateUser.TabIndex = 10;
            this.grpCreateUser.TabStop = false;
            this.grpCreateUser.Text = "Create User";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(108, 21);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(372, 26);
            this.txtUserId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "id";
            this.label1.Visible = false;
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.cboType.Location = new System.Drawing.Point(108, 136);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(372, 28);
            this.cboType.TabIndex = 14;
            this.cboType.Text = "Administrator";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.White;
            this.lblUserId.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserId.Location = new System.Drawing.Point(41, 25);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(59, 22);
            this.lblUserId.TabIndex = 12;
            this.lblUserId.Text = "User Id:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(108, 99);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(372, 26);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(47, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Type :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(108, 62);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(372, 26);
            this.txtUserName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(13, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password :";
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 639);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Name = "frmCreateUser";
            this.Text = "Megavox : Create User";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUser)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.grpCreateUser.ResumeLayout(false);
            this.grpCreateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView GrdUser;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.GroupBox grpCreateUser;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtUserId;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblUserId;
    }
}