namespace DMS.UI.SystemManage.RoleManage
{
    partial class RoleFormBase
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
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dmsLabel1 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtID = new DMS.UI.CustomerControl.DMSTextBox();
            this.dmsLabel2 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtName = new DMS.UI.CustomerControl.DMSTextBox();
            this.dmsLabel3 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel4 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtMemo = new DMS.UI.CustomerControl.DMSMutilineTextbox();
            this.tvModule = new DMS.UI.CustomerControl.DMSTreeView();
            this.btnSelectChildren = new DMS.UI.CustomerControl.DMSButton();
            this.gbRole.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRole
            // 
            this.gbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRole.Controls.Add(this.tableLayoutPanel1);
            this.gbRole.Location = new System.Drawing.Point(11, 83);
            this.gbRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRole.Name = "gbRole";
            this.gbRole.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRole.Size = new System.Drawing.Size(473, 526);
            this.gbRole.TabIndex = 1;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "角色信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMemo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tvModule, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectChildren, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dmsLabel1
            // 
            this.dmsLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel1.AutoSize = true;
            this.dmsLabel1.Location = new System.Drawing.Point(20, 8);
            this.dmsLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmsLabel1.Name = "dmsLabel1";
            this.dmsLabel1.Size = new System.Drawing.Size(56, 16);
            this.dmsLabel1.TabIndex = 0;
            this.dmsLabel1.Text = "角色ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(80, 3);
            this.txtID.Margin = new System.Windows.Forms.Padding(0);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(375, 26);
            this.txtID.TabIndex = 1;
            // 
            // dmsLabel2
            // 
            this.dmsLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel2.AutoSize = true;
            this.dmsLabel2.Location = new System.Drawing.Point(4, 41);
            this.dmsLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmsLabel2.Name = "dmsLabel2";
            this.dmsLabel2.Size = new System.Drawing.Size(72, 16);
            this.dmsLabel2.TabIndex = 0;
            this.dmsLabel2.Text = "角色名称";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(80, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 26);
            this.txtName.TabIndex = 1;
            // 
            // dmsLabel3
            // 
            this.dmsLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel3.AutoSize = true;
            this.dmsLabel3.Location = new System.Drawing.Point(4, 218);
            this.dmsLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmsLabel3.Name = "dmsLabel3";
            this.dmsLabel3.Size = new System.Drawing.Size(72, 16);
            this.dmsLabel3.TabIndex = 0;
            this.dmsLabel3.Text = "角色功能";
            // 
            // dmsLabel4
            // 
            this.dmsLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel4.AutoSize = true;
            this.dmsLabel4.Location = new System.Drawing.Point(36, 412);
            this.dmsLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmsLabel4.Name = "dmsLabel4";
            this.dmsLabel4.Size = new System.Drawing.Size(40, 16);
            this.dmsLabel4.TabIndex = 0;
            this.dmsLabel4.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemo.Location = new System.Drawing.Point(80, 354);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(0);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemo.Size = new System.Drawing.Size(375, 133);
            this.txtMemo.TabIndex = 2;
            // 
            // tvModule
            // 
            this.tvModule.CheckBoxes = true;
            this.tvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvModule.Location = new System.Drawing.Point(80, 99);
            this.tvModule.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tvModule.Name = "tvModule";
            this.tvModule.Size = new System.Drawing.Size(375, 251);
            this.tvModule.TabIndex = 3;
            // 
            // btnSelectChildren
            // 
            this.btnSelectChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectChildren.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectChildren.Location = new System.Drawing.Point(354, 66);
            this.btnSelectChildren.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectChildren.Name = "btnSelectChildren";
            this.btnSelectChildren.Size = new System.Drawing.Size(101, 29);
            this.btnSelectChildren.TabIndex = 4;
            this.btnSelectChildren.Text = "选择子节点";
            this.btnSelectChildren.UseVisualStyleBackColor = true;
            this.btnSelectChildren.Click += new System.EventHandler(this.btnSelectChildren_Click);
            // 
            // RoleFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 616);
            this.Controls.Add(this.gbRole);
            this.Name = "RoleFormBase";
            this.Text = "RoleFormBase";
            this.Load += new System.EventHandler(this.RoleFormBase_Load);
            this.Controls.SetChildIndex(this.gbRole, 0);
            this.gbRole.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel1;
        private DMS.UI.CustomerControl.DMSTextBox txtID;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel2;
        private DMS.UI.CustomerControl.DMSTextBox txtName;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel3;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel4;
        private DMS.UI.CustomerControl.DMSMutilineTextbox txtMemo;
        private DMS.UI.CustomerControl.DMSTreeView tvModule;
        private DMS.UI.CustomerControl.DMSButton btnSelectChildren;
    }
}