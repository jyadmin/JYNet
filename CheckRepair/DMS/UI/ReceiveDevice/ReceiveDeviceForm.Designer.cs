namespace DMS.UI.DeviceReceives
{
    partial class DeviceReceiveForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dmsLabel1 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel2 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel3 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel4 = new DMS.UI.CustomerControl.DMSLabel();
            this.dmsLabel5 = new DMS.UI.CustomerControl.DMSLabel();
            this.cmbEngineType = new DMS.UI.CustomerControl.DMSCombox();
            this.cmbDeviceType = new DMS.UI.CustomerControl.DMSCombox();
            this.cmbXc = new DMS.UI.CustomerControl.DMSCombox();
            this.tbEngineCode = new DMS.UI.CustomerControl.DMSTextBox();
            this.tbDeviceCode = new DMS.UI.CustomerControl.DMSTextBox();
            this.dmsLabel7 = new DMS.UI.CustomerControl.DMSLabel();
            this.tbReceiver = new DMS.UI.CustomerControl.DMSTextBox();
            this.btnSave = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备接收";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbEngineType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDeviceType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbXc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbEngineCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDeviceCode, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dmsLabel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbReceiver, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dmsLabel1
            // 
            this.dmsLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel1.AutoSize = true;
            this.dmsLabel1.Location = new System.Drawing.Point(56, 20);
            this.dmsLabel1.Name = "dmsLabel1";
            this.dmsLabel1.Size = new System.Drawing.Size(40, 16);
            this.dmsLabel1.TabIndex = 0;
            this.dmsLabel1.Text = "车型";
            // 
            // dmsLabel2
            // 
            this.dmsLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel2.AutoSize = true;
            this.dmsLabel2.Location = new System.Drawing.Point(56, 76);
            this.dmsLabel2.Name = "dmsLabel2";
            this.dmsLabel2.Size = new System.Drawing.Size(40, 16);
            this.dmsLabel2.TabIndex = 0;
            this.dmsLabel2.Text = "车号";
            // 
            // dmsLabel3
            // 
            this.dmsLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel3.AutoSize = true;
            this.dmsLabel3.Location = new System.Drawing.Point(56, 132);
            this.dmsLabel3.Name = "dmsLabel3";
            this.dmsLabel3.Size = new System.Drawing.Size(40, 16);
            this.dmsLabel3.TabIndex = 0;
            this.dmsLabel3.Text = "修程";
            // 
            // dmsLabel4
            // 
            this.dmsLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel4.AutoSize = true;
            this.dmsLabel4.Location = new System.Drawing.Point(24, 188);
            this.dmsLabel4.Name = "dmsLabel4";
            this.dmsLabel4.Size = new System.Drawing.Size(72, 16);
            this.dmsLabel4.TabIndex = 0;
            this.dmsLabel4.Text = "设备类型";
            // 
            // dmsLabel5
            // 
            this.dmsLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel5.AutoSize = true;
            this.dmsLabel5.Location = new System.Drawing.Point(24, 244);
            this.dmsLabel5.Name = "dmsLabel5";
            this.dmsLabel5.Size = new System.Drawing.Size(72, 16);
            this.dmsLabel5.TabIndex = 0;
            this.dmsLabel5.Text = "设备编号";
            // 
            // cmbEngineType
            // 
            this.cmbEngineType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEngineType.FormattingEnabled = true;
            this.cmbEngineType.Location = new System.Drawing.Point(99, 18);
            this.cmbEngineType.Margin = new System.Windows.Forms.Padding(0);
            this.cmbEngineType.Name = "cmbEngineType";
            this.cmbEngineType.Size = new System.Drawing.Size(297, 24);
            this.cmbEngineType.TabIndex = 1;
            this.cmbEngineType.SelectedIndexChanged += new System.EventHandler(this.LoadDeviceTypeInfo);
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceType.FormattingEnabled = true;
            this.cmbDeviceType.Location = new System.Drawing.Point(99, 186);
            this.cmbDeviceType.Margin = new System.Windows.Forms.Padding(0);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(297, 24);
            this.cmbDeviceType.TabIndex = 3;
            // 
            // cmbXc
            // 
            this.cmbXc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbXc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXc.FormattingEnabled = true;
            this.cmbXc.Location = new System.Drawing.Point(99, 130);
            this.cmbXc.Margin = new System.Windows.Forms.Padding(0);
            this.cmbXc.Name = "cmbXc";
            this.cmbXc.Size = new System.Drawing.Size(297, 24);
            this.cmbXc.TabIndex = 2;
            this.cmbXc.SelectedIndexChanged += new System.EventHandler(this.LoadDeviceTypeInfo);
            // 
            // tbEngineCode
            // 
            this.tbEngineCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEngineCode.Location = new System.Drawing.Point(99, 71);
            this.tbEngineCode.Margin = new System.Windows.Forms.Padding(0);
            this.tbEngineCode.Name = "tbEngineCode";
            this.tbEngineCode.Size = new System.Drawing.Size(297, 26);
            this.tbEngineCode.TabIndex = 4;
            // 
            // tbDeviceCode
            // 
            this.tbDeviceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeviceCode.Location = new System.Drawing.Point(99, 239);
            this.tbDeviceCode.Margin = new System.Windows.Forms.Padding(0);
            this.tbDeviceCode.Name = "tbDeviceCode";
            this.tbDeviceCode.Size = new System.Drawing.Size(297, 26);
            this.tbDeviceCode.TabIndex = 4;
            // 
            // dmsLabel7
            // 
            this.dmsLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dmsLabel7.AutoSize = true;
            this.dmsLabel7.Location = new System.Drawing.Point(40, 302);
            this.dmsLabel7.Name = "dmsLabel7";
            this.dmsLabel7.Size = new System.Drawing.Size(56, 16);
            this.dmsLabel7.TabIndex = 0;
            this.dmsLabel7.Text = "接收人";
            // 
            // tbReceiver
            // 
            this.tbReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReceiver.Location = new System.Drawing.Point(99, 297);
            this.tbReceiver.Margin = new System.Windows.Forms.Padding(0);
            this.tbReceiver.Name = "tbReceiver";
            this.tbReceiver.Size = new System.Drawing.Size(297, 26);
            this.tbReceiver.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(37, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "完  成";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.tbcSave_Commanded);
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(287, 427);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(88, 28);
            this.txButton1.TabIndex = 1;
            this.txButton1.Text = "取  消";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.CloseForm);
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(161, 427);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(88, 28);
            this.txButton2.TabIndex = 1;
            this.txButton2.Text = "派  工";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.CloseForm);
            // 
            // DeviceReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 467);
            this.Controls.Add(this.txButton2);
            this.Controls.Add(this.txButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceReceiveForm";
            this.Text = "风机接收";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomerControl.DMSLabel dmsLabel1;
        private CustomerControl.DMSLabel dmsLabel2;
        private CustomerControl.DMSLabel dmsLabel3;
        private CustomerControl.DMSLabel dmsLabel4;
        private CustomerControl.DMSLabel dmsLabel5;
        private CustomerControl.DMSCombox cmbEngineType;
        private CustomerControl.DMSCombox cmbXc;
        private CustomerControl.DMSCombox cmbDeviceType;
        private CustomerControl.DMSTextBox tbEngineCode;
        private CustomerControl.DMSTextBox tbDeviceCode;
        private CustomerControl.DMSLabel dmsLabel7;
        private CustomerControl.DMSTextBox tbReceiver;
        private TX.Framework.WindowUI.Controls.TXButton btnSave;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
    }
}