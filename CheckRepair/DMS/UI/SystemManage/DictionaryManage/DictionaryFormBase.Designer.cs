namespace DMS.UI.SystemManage.DictionaryManage
{
    partial class DictionaryFormBase
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
            this.dmsLabel6 = new DMS.UI.CustomerControl.DMSLabel();
            this.txtDictionaryId = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtName = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtDisplayOrder = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtPriorID = new DMS.UI.CustomerControl.DMSTextBox();
            this.txtTypeName = new DMS.UI.CustomerControl.DMSTextBox();
            this.gbDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.tableLayoutPanel1);
            this.gbDetail.Location = new System.Drawing.Point(8, 51);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(351, 152);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "数据项信息";
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
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDictionaryId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDisplayOrder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPriorID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTypeName, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dmsLabel1
            // 
            this.dmsLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel1.AutoSize = true;
            this.dmsLabel1.Location = new System.Drawing.Point(4, 6);
            this.dmsLabel1.Name = "dmsLabel1";
            this.dmsLabel1.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel1.TabIndex = 0;
            this.dmsLabel1.Text = "数据项ID";
            // 
            // dmsLabel2
            // 
            this.dmsLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel2.AutoSize = true;
            this.dmsLabel2.Location = new System.Drawing.Point(16, 31);
            this.dmsLabel2.Name = "dmsLabel2";
            this.dmsLabel2.Size = new System.Drawing.Size(41, 12);
            this.dmsLabel2.TabIndex = 1;
            this.dmsLabel2.Text = "数据项";
            // 
            // dmsLabel3
            // 
            this.dmsLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel3.AutoSize = true;
            this.dmsLabel3.Location = new System.Drawing.Point(4, 56);
            this.dmsLabel3.Name = "dmsLabel3";
            this.dmsLabel3.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel3.TabIndex = 2;
            this.dmsLabel3.Text = "显示顺序";
            // 
            // dmsLabel4
            // 
            this.dmsLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel4.AutoSize = true;
            this.dmsLabel4.Location = new System.Drawing.Point(4, 81);
            this.dmsLabel4.Name = "dmsLabel4";
            this.dmsLabel4.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel4.TabIndex = 2;
            this.dmsLabel4.Text = "父数据项";
            // 
            // dmsLabel6
            // 
            this.dmsLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel6.AutoSize = true;
            this.dmsLabel6.Location = new System.Drawing.Point(4, 106);
            this.dmsLabel6.Name = "dmsLabel6";
            this.dmsLabel6.Size = new System.Drawing.Size(53, 12);
            this.dmsLabel6.TabIndex = 2;
            this.dmsLabel6.Text = "数据类型";
            // 
            // txtDictionaryId
            // 
            this.txtDictionaryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDictionaryId.BackColor = System.Drawing.Color.White;
            this.txtDictionaryId.Location = new System.Drawing.Point(60, 2);
            this.txtDictionaryId.Margin = new System.Windows.Forms.Padding(0);
            this.txtDictionaryId.Name = "txtDictionaryId";
            this.txtDictionaryId.ReadOnly = true;
            this.txtDictionaryId.Size = new System.Drawing.Size(284, 21);
            this.txtDictionaryId.TabIndex = 4;
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
            // txtDisplayOrder
            // 
            this.txtDisplayOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayOrder.Location = new System.Drawing.Point(60, 52);
            this.txtDisplayOrder.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplayOrder.MaxLength = 200;
            this.txtDisplayOrder.Name = "txtDisplayOrder";
            this.txtDisplayOrder.Size = new System.Drawing.Size(284, 21);
            this.txtDisplayOrder.TabIndex = 4;
            // 
            // txtPriorID
            // 
            this.txtPriorID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorID.Location = new System.Drawing.Point(60, 77);
            this.txtPriorID.Margin = new System.Windows.Forms.Padding(0);
            this.txtPriorID.MaxLength = 5;
            this.txtPriorID.Name = "txtPriorID";
            this.txtPriorID.Size = new System.Drawing.Size(284, 21);
            this.txtPriorID.TabIndex = 4;
            this.txtPriorID.Text = "0";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeName.Location = new System.Drawing.Point(60, 102);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(0);
            this.txtTypeName.MaxLength = 5;
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(284, 21);
            this.txtTypeName.TabIndex = 4;
            // 
            // DictionaryFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 211);
            this.Controls.Add(this.gbDetail);
            this.Name = "DictionaryFormBase";
            this.Text = "DictionaryFormBase";
            this.Load += new System.EventHandler(this.DictionaryFormBase_Load);
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
        private DMS.UI.CustomerControl.DMSLabel dmsLabel6;
        private DMS.UI.CustomerControl.DMSTextBox txtDictionaryId;
        private DMS.UI.CustomerControl.DMSTextBox txtName;
        private DMS.UI.CustomerControl.DMSTextBox txtDisplayOrder;
        private DMS.UI.CustomerControl.DMSTextBox txtPriorID;
        private DMS.UI.CustomerControl.DMSTextBox txtTypeName;
    }
}