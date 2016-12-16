namespace DMS.UI.SystemManage.ModuleManage
{
    partial class ModuleFormBase
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
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dmsLabel1 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel2 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel3 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel4 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel5 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel6 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel7 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtMemo = new DMS.UI.CustomerControl.DMSMutilineTextbox();
            this.txtModuleId = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtName = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtRunner = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtPriorModule = new DMS.UI.CustomerControl.DMSTextBox();
            this.cbDisplay = new System.Windows.Forms.CheckBox();
            this.txtDisplayOrder = new DMS.UI.CustomerControl.DMSTextBox();
            this.gbDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.tableLayoutPanel1);
            this.gbDetail.Location = new System.Drawing.Point(8, 51);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(356, 370);
            this.gbDetail.TabIndex = 1;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "功能模块信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMemo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtModuleId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRunner, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPriorModule, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDisplay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDisplayOrder, 1, 5);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 344);
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
            this.dmsLabel1.Text = "模块ID";
            // 
            // dmsLabel2
            // 
            this.dmsLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel2.AutoSize = true;
            this.dmsLabel2.Location = new System.Drawing.Point(4, 31);
            this.dmsLabel2.Name = "dmsLabel2";
            this.dmsLabel2.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel2.TabIndex = 1;
            this.dmsLabel2.Text = "模块名称";
            // 
            // dmsLabel3
            // 
            this.dmsLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel3.AutoSize = true;
            this.dmsLabel3.Location = new System.Drawing.Point(16, 56);
            this.dmsLabel3.Name = "dmsLabel3";
            this.dmsLabel3.Size = new System.Drawing.Size(41, 12);
            this.dmsLabel3.TabIndex = 2;
            this.dmsLabel3.Text = "启动类";
            // 
            // dmsLabel4
            // 
            this.dmsLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel4.AutoSize = true;
            this.dmsLabel4.Location = new System.Drawing.Point(4, 81);
            this.dmsLabel4.Name = "dmsLabel4";
            this.dmsLabel4.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel4.TabIndex = 2;
            this.dmsLabel4.Text = "上级模块";
            // 
            // dmsLabel5
            // 
            this.dmsLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel5.AutoSize = true;
            this.dmsLabel5.Location = new System.Drawing.Point(4, 106);
            this.dmsLabel5.Name = "dmsLabel5";
            this.dmsLabel5.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel5.TabIndex = 2;
            this.dmsLabel5.Text = "是否显示";
            // 
            // dmsLabel6
            // 
            this.dmsLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel6.AutoSize = true;
            this.dmsLabel6.Location = new System.Drawing.Point(4, 131);
            this.dmsLabel6.Name = "dmsLabel6";
            this.dmsLabel6.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel6.TabIndex = 2;
            this.dmsLabel6.Text = "显示顺序";
            // 
            // dmsLabel7
            // 
            this.dmsLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel7.AutoSize = true;
            this.dmsLabel7.Location = new System.Drawing.Point(28, 241);
            this.dmsLabel7.Name = "dmsLabel7";
            this.dmsLabel7.Size = new System.Drawing.Size(29, 12);
            this.dmsLabel7.TabIndex = 2;
            this.dmsLabel7.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemo.Location = new System.Drawing.Point(60, 150);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(0);
            this.txtMemo.MaxLength = 200;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemo.Size = new System.Drawing.Size(284, 194);
            this.txtMemo.TabIndex = 3;
            // 
            // txtModuleId
            // 
            this.txtModuleId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModuleId.BackColor = System.Drawing.Color.White;
            this.txtModuleId.Location = new System.Drawing.Point(60, 2);
            this.txtModuleId.Margin = new System.Windows.Forms.Padding(0);
            this.txtModuleId.Name = "txtModuleId";
            this.txtModuleId.ReadOnly = true;
            this.txtModuleId.Size = new System.Drawing.Size(284, 21);
            this.txtModuleId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(60, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtRunner
            // 
            this.txtRunner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRunner.Location = new System.Drawing.Point(60, 52);
            this.txtRunner.Margin = new System.Windows.Forms.Padding(0);
            this.txtRunner.MaxLength = 200;
            this.txtRunner.Name = "txtRunner";
            this.txtRunner.Size = new System.Drawing.Size(284, 21);
            this.txtRunner.TabIndex = 4;
            // 
            // txtPriorModule
            // 
            this.txtPriorModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorModule.Location = new System.Drawing.Point(60, 77);
            this.txtPriorModule.Margin = new System.Windows.Forms.Padding(0);
            this.txtPriorModule.MaxLength = 5;
            this.txtPriorModule.Name = "txtPriorModule";
            this.txtPriorModule.Size = new System.Drawing.Size(284, 21);
            this.txtPriorModule.TabIndex = 4;
            this.txtPriorModule.Text = "1";
            // 
            // cbDisplay
            // 
            this.cbDisplay.AutoSize = true;
            this.cbDisplay.Location = new System.Drawing.Point(63, 103);
            this.cbDisplay.Name = "cbDisplay";
            this.cbDisplay.Size = new System.Drawing.Size(15, 14);
            this.cbDisplay.TabIndex = 5;
            this.cbDisplay.UseVisualStyleBackColor = true;
            // 
            // txtDisplayOrder
            // 
            this.txtDisplayOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayOrder.Location = new System.Drawing.Point(60, 127);
            this.txtDisplayOrder.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplayOrder.MaxLength = 5;
            this.txtDisplayOrder.Name = "txtDisplayOrder";
            this.txtDisplayOrder.Size = new System.Drawing.Size(284, 21);
            this.txtDisplayOrder.TabIndex = 4;
            // 
            // ModuleFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(371, 427);
            this.Controls.Add(this.gbDetail);
            this.Name = "ModuleFormBase";
            this.Load += new System.EventHandler(this.ModuleFormBase_Load);
            this.Controls.SetChildIndex(this.gbDetail, 0);
            this.gbDetail.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel1;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel2;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel3;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel4;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel5;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel6;
        private DMS.UI.CustomerControl.DMSLabel dmsLabel7;
        private DMS.UI.CustomerControl.DMSMutilineTextbox txtMemo;
        private DMS.UI.CustomerControl.DMSTextBox txtModuleId;
        private DMS.UI.CustomerControl.DMSTextBox txtName;
        private DMS.UI.CustomerControl.DMSTextBox txtRunner;
        private DMS.UI.CustomerControl.DMSTextBox txtPriorModule;
        private System.Windows.Forms.CheckBox cbDisplay;
        private DMS.UI.CustomerControl.DMSTextBox txtDisplayOrder;
    }
}
