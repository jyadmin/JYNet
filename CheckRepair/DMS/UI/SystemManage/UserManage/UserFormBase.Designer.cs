namespace DMS.UI.SystemManage.UserManage
{
    partial class UserFormBase
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dmsLabel1 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel2 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel3 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel4 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel5 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel6 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtuserId = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtLoginName = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtPassword = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtDuty = new DMS.UI.CustomerControl.DMSTextBox();
            this.cmbRole = new DMS.UI.CustomerControl.DMSCombox();
            this.txtDescript = new DMS.UI.CustomerControl.DMSMutilineTextbox();
            this.dmsLabel7 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtUserName = new DMS.UI.CustomerControl.DMSTextBox();
            this.gbUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUser.Controls.Add(this.tableLayoutPanel1);
            this.gbUser.Location = new System.Drawing.Point(8, 51);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(269, 290);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "用户基本信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtuserId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLoginName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDuty, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbRole, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDescript, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dmsLabel1
            // 
            this.dmsLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel1.AutoSize = true;
            this.dmsLabel1.Location = new System.Drawing.Point(16, 6);
            this.dmsLabel1.Name = "dmsLabel1";
            this.dmsLabel1.Size = new System.Drawing.Size(41, 12);
            this.dmsLabel1.TabIndex = 0;
            this.dmsLabel1.Text = "用户ID";
            // 
            // dmsLabel2
            // 
            this.dmsLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel2.AutoSize = true;
            this.dmsLabel2.Location = new System.Drawing.Point(4, 31);
            this.dmsLabel2.Name = "dmsLabel2";
            this.dmsLabel2.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel2.TabIndex = 0;
            this.dmsLabel2.Text = "登陆帐名";
            // 
            // dmsLabel3
            // 
            this.dmsLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel3.AutoSize = true;
            this.dmsLabel3.Location = new System.Drawing.Point(4, 56);
            this.dmsLabel3.Name = "dmsLabel3";
            this.dmsLabel3.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel3.TabIndex = 0;
            this.dmsLabel3.Text = "登陆密码";
            // 
            // dmsLabel4
            // 
            this.dmsLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel4.AutoSize = true;
            this.dmsLabel4.Location = new System.Drawing.Point(28, 106);
            this.dmsLabel4.Name = "dmsLabel4";
            this.dmsLabel4.Size = new System.Drawing.Size(29, 12);
            this.dmsLabel4.TabIndex = 0;
            this.dmsLabel4.Text = "职责";
            // 
            // dmsLabel5
            // 
            this.dmsLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel5.AutoSize = true;
            this.dmsLabel5.Location = new System.Drawing.Point(28, 131);
            this.dmsLabel5.Name = "dmsLabel5";
            this.dmsLabel5.Size = new System.Drawing.Size(29, 12);
            this.dmsLabel5.TabIndex = 0;
            this.dmsLabel5.Text = "角色";
            // 
            // dmsLabel6
            // 
            this.dmsLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel6.AutoSize = true;
            this.dmsLabel6.Location = new System.Drawing.Point(28, 200);
            this.dmsLabel6.Name = "dmsLabel6";
            this.dmsLabel6.Size = new System.Drawing.Size(29, 12);
            this.dmsLabel6.TabIndex = 0;
            this.dmsLabel6.Text = "备注";
            // 
            // txtuserId
            // 
            this.txtuserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtuserId.BackColor = System.Drawing.Color.White;
            this.txtuserId.Location = new System.Drawing.Point(60, 2);
            this.txtuserId.Margin = new System.Windows.Forms.Padding(0);
            this.txtuserId.Name = "txtuserId";
            this.txtuserId.ReadOnly = true;
            this.txtuserId.Size = new System.Drawing.Size(195, 21);
            this.txtuserId.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginName.Location = new System.Drawing.Point(60, 27);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoginName.MaxLength = 10;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(195, 21);
            this.txtLoginName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(60, 52);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtDuty
            // 
            this.txtDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuty.Location = new System.Drawing.Point(60, 102);
            this.txtDuty.Margin = new System.Windows.Forms.Padding(0);
            this.txtDuty.Name = "txtDuty";
            this.txtDuty.Size = new System.Drawing.Size(195, 21);
            this.txtDuty.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(60, 127);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(0);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(195, 20);
            this.cmbRole.TabIndex = 2;
            // 
            // txtDescript
            // 
            this.txtDescript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescript.Location = new System.Drawing.Point(60, 150);
            this.txtDescript.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescript.MaxLength = 100;
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescript.Size = new System.Drawing.Size(195, 112);
            this.txtDescript.TabIndex = 3;
            // 
            // dmsLabel7
            // 
            this.dmsLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel7.AutoSize = true;
            this.dmsLabel7.Location = new System.Drawing.Point(16, 81);
            this.dmsLabel7.Name = "dmsLabel7";
            this.dmsLabel7.Size = new System.Drawing.Size(41, 12);
            this.dmsLabel7.TabIndex = 0;
            this.dmsLabel7.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(60, 77);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // UserFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 350);
            this.Controls.Add(this.gbUser);
            this.Name = "UserFormBase";
            this.Text = "UserFormBase";
            this.Load += new System.EventHandler(this.UserFormBase_Load);
            this.Controls.SetChildIndex(this.gbUser, 0);
            this.gbUser.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel1;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel2;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel3;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel4;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel5;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel6;
        private DMS.UI.CustomerControl.DMSTextBox txtuserId;
        private DMS.UI.CustomerControl.DMSTextBox txtLoginName;
        private DMS.UI.CustomerControl.DMSTextBox txtPassword;
        private DMS.UI.CustomerControl.DMSTextBox txtDuty;
        private DMS.UI.CustomerControl.DMSCombox cmbRole;
        private DMS.UI.CustomerControl.DMSMutilineTextbox txtDescript;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel7;
        private DMS.UI.CustomerControl.DMSTextBox txtUserName;
    }
}