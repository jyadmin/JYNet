namespace DMS.UI.Inspect
{
    partial class InspectForm
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
            TX.Framework.WindowUI.Controls.TreeListViewItemCollection.TreeListViewItemCollectionComparer treeListViewItemCollectionComparer4 = new TX.Framework.WindowUI.Controls.TreeListViewItemCollection.TreeListViewItemCollectionComparer();
            this.txPanelCenter = new TX.Framework.WindowUI.Controls.TXPanel();
            this.treeListView = new TX.Framework.WindowUI.Controls.TreeListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txPanelBottom = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelTop = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanel1 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDateTimePicker2 = new TX.Framework.WindowUI.Controls.TXDateTimePicker();
            this.txDateTimePicker1 = new TX.Framework.WindowUI.Controls.TXDateTimePicker();
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelCenter.SuspendLayout();
            this.txPanelTop.SuspendLayout();
            this.txPanel1.SuspendLayout();
            this.txPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txPanelCenter
            // 
            this.txPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.txPanelCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelCenter.Controls.Add(this.treeListView);
            this.txPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelCenter.Location = new System.Drawing.Point(0, 49);
            this.txPanelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelCenter.Name = "txPanelCenter";
            this.txPanelCenter.Size = new System.Drawing.Size(1378, 510);
            this.txPanelCenter.TabIndex = 6;
            // 
            // treeListView
            // 
            this.treeListView.BackColor = System.Drawing.Color.White;
            this.treeListView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            treeListViewItemCollectionComparer4.Column = 0;
            treeListViewItemCollectionComparer4.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeListView.Comparer = treeListViewItemCollectionComparer4;
            this.treeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeListView.HeaderBeginColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.treeListView.HeaderEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.treeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.treeListView.Location = new System.Drawing.Point(0, 0);
            this.treeListView.Margin = new System.Windows.Forms.Padding(4);
            this.treeListView.MultiSelect = false;
            this.treeListView.Name = "treeListView";
            this.treeListView.OwnerDraw = true;
            this.treeListView.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.treeListView.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.treeListView.SelectedBeginColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.treeListView.SelectedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(225)))), ((int)(((byte)(253)))));
            this.treeListView.Size = new System.Drawing.Size(1378, 510);
            this.treeListView.Sorting = System.Windows.Forms.SortOrder.None;
            this.treeListView.TabIndex = 0;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.DoubleClick += new System.EventHandler(this.treeListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "下车号";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "下车时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "部件";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "排序";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 54;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "工位（工序）";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 226;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "作业时长";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "分配人员";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "计划开始时间";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 190;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "实际开始时间";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 185;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "实际结束时间";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 183;
            // 
            // txPanelBottom
            // 
            this.txPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.txPanelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanelBottom.Location = new System.Drawing.Point(0, 559);
            this.txPanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelBottom.Name = "txPanelBottom";
            this.txPanelBottom.Size = new System.Drawing.Size(1378, 56);
            this.txPanelBottom.TabIndex = 5;
            // 
            // txPanelTop
            // 
            this.txPanelTop.BackColor = System.Drawing.Color.Transparent;
            this.txPanelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelTop.Controls.Add(this.txPanel1);
            this.txPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txPanelTop.Location = new System.Drawing.Point(0, 0);
            this.txPanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelTop.Name = "txPanelTop";
            this.txPanelTop.Size = new System.Drawing.Size(1378, 49);
            this.txPanelTop.TabIndex = 3;
            // 
            // txPanel1
            // 
            this.txPanel1.BackColor = System.Drawing.Color.Transparent;
            this.txPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel1.Controls.Add(this.label3);
            this.txPanel1.Controls.Add(this.label2);
            this.txPanel1.Controls.Add(this.txDateTimePicker2);
            this.txPanel1.Controls.Add(this.txDateTimePicker1);
            this.txPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel1.Location = new System.Drawing.Point(0, 0);
            this.txPanel1.Name = "txPanel1";
            this.txPanel1.Size = new System.Drawing.Size(1378, 49);
            this.txPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "—";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "设备接收时间：";
            // 
            // txDateTimePicker2
            // 
            this.txDateTimePicker2.CalendarForeColor = System.Drawing.Color.Blue;
            this.txDateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txDateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))), ((int)(((byte)(237)))));
            this.txDateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.CadetBlue;
            this.txDateTimePicker2.Checked = false;
            this.txDateTimePicker2.Location = new System.Drawing.Point(312, 9);
            this.txDateTimePicker2.Name = "txDateTimePicker2";
            this.txDateTimePicker2.ShowCheckBox = true;
            this.txDateTimePicker2.Size = new System.Drawing.Size(140, 26);
            this.txDateTimePicker2.TabIndex = 1;
            this.txDateTimePicker2.Value = null;
            this.txDateTimePicker2.ValueChanged += new System.EventHandler(this.txDateTimePicker_ValueChanged);
            // 
            // txDateTimePicker1
            // 
            this.txDateTimePicker1.CalendarForeColor = System.Drawing.Color.Blue;
            this.txDateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txDateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))), ((int)(((byte)(237)))));
            this.txDateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.CadetBlue;
            this.txDateTimePicker1.Checked = false;
            this.txDateTimePicker1.Location = new System.Drawing.Point(136, 9);
            this.txDateTimePicker1.Name = "txDateTimePicker1";
            this.txDateTimePicker1.ShowCheckBox = true;
            this.txDateTimePicker1.Size = new System.Drawing.Size(140, 26);
            this.txDateTimePicker1.TabIndex = 1;
            this.txDateTimePicker1.Value = null;
            this.txDateTimePicker1.ValueChanged += new System.EventHandler(this.txDateTimePicker_ValueChanged);
            // 
            // txPanel3
            // 
            this.txPanel3.BackColor = System.Drawing.Color.Transparent;
            this.txPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel3.Controls.Add(this.txPanelCenter);
            this.txPanel3.Controls.Add(this.txPanelBottom);
            this.txPanel3.Controls.Add(this.txPanelTop);
            this.txPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel3.Location = new System.Drawing.Point(3, 27);
            this.txPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.txPanel3.Name = "txPanel3";
            this.txPanel3.Size = new System.Drawing.Size(1378, 615);
            this.txPanel3.TabIndex = 5;
            // 
            // InspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CapitionLogo = null;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1384, 645);
            this.Controls.Add(this.txPanel3);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InspectForm";
            this.ResizeEnable = false;
            this.Text = "互 检";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.txPanelCenter.ResumeLayout(false);
            this.txPanelTop.ResumeLayout(false);
            this.txPanel1.ResumeLayout(false);
            this.txPanel1.PerformLayout();
            this.txPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXPanel txPanelCenter;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelBottom;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelTop;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel3;
        private TX.Framework.WindowUI.Controls.TreeListView treeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel1;
        private TX.Framework.WindowUI.Controls.TXDateTimePicker txDateTimePicker1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TX.Framework.WindowUI.Controls.TXDateTimePicker txDateTimePicker2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}