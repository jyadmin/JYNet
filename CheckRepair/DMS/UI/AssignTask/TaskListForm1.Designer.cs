namespace DMS.UI.AssignTask
{
    partial class TaskListForm1
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
            TX.Framework.WindowUI.Controls.TreeListViewItemCollection.TreeListViewItemCollectionComparer treeListViewItemCollectionComparer6 = new TX.Framework.WindowUI.Controls.TreeListViewItemCollection.TreeListViewItemCollectionComparer();
            this.btnHXD1DC5 = new System.Windows.Forms.Button();
            this.txPanelCenter = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelTreeListView = new TX.Framework.WindowUI.Controls.TXPanel();
            this.treeListView1 = new TX.Framework.WindowUI.Controls.TreeListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txPanelUser = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.txPanelLeft = new TX.Framework.WindowUI.Controls.TXPanel();
            this.tvEngineCode = new System.Windows.Forms.TreeView();
            this.btnHXD1BC5 = new System.Windows.Forms.Button();
            this.btnHXD1C5 = new System.Windows.Forms.Button();
            this.btnHXD3C5 = new System.Windows.Forms.Button();
            this.btnHXD3CC5 = new System.Windows.Forms.Button();
            this.btnHXD3CC4 = new System.Windows.Forms.Button();
            this.txPanelBottom = new TX.Framework.WindowUI.Controls.TXPanel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txPanelTop = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanel1 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txDateTimePicker1 = new TX.Framework.WindowUI.Controls.TXDateTimePicker();
            this.txCbbStatus = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.txPanelBtn = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txPanelCenter.SuspendLayout();
            this.txPanelTreeListView.SuspendLayout();
            this.txPanelUser.SuspendLayout();
            this.txPanelLeft.SuspendLayout();
            this.txPanelBottom.SuspendLayout();
            this.txPanelTop.SuspendLayout();
            this.txPanel1.SuspendLayout();
            this.txPanelBtn.SuspendLayout();
            this.txPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHXD1DC5
            // 
            this.btnHXD1DC5.Location = new System.Drawing.Point(226, 13);
            this.btnHXD1DC5.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD1DC5.Name = "btnHXD1DC5";
            this.btnHXD1DC5.Size = new System.Drawing.Size(123, 37);
            this.btnHXD1DC5.TabIndex = 6;
            this.btnHXD1DC5.Text = "HXD1D-C5";
            this.btnHXD1DC5.UseVisualStyleBackColor = true;
            this.btnHXD1DC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // txPanelCenter
            // 
            this.txPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.txPanelCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelCenter.Controls.Add(this.txPanelTreeListView);
            this.txPanelCenter.Controls.Add(this.txPanelUser);
            this.txPanelCenter.Controls.Add(this.txPanelLeft);
            this.txPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelCenter.Location = new System.Drawing.Point(0, 108);
            this.txPanelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelCenter.Name = "txPanelCenter";
            this.txPanelCenter.Size = new System.Drawing.Size(1378, 451);
            this.txPanelCenter.TabIndex = 6;
            // 
            // txPanelTreeListView
            // 
            this.txPanelTreeListView.BackColor = System.Drawing.Color.Transparent;
            this.txPanelTreeListView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelTreeListView.Controls.Add(this.treeListView1);
            this.txPanelTreeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelTreeListView.Location = new System.Drawing.Point(261, 0);
            this.txPanelTreeListView.Name = "txPanelTreeListView";
            this.txPanelTreeListView.Size = new System.Drawing.Size(680, 451);
            this.txPanelTreeListView.TabIndex = 8;
            // 
            // treeListView1
            // 
            this.treeListView1.BackColor = System.Drawing.Color.White;
            this.treeListView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            treeListViewItemCollectionComparer6.Column = 0;
            treeListViewItemCollectionComparer6.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeListView1.Comparer = treeListViewItemCollectionComparer6;
            this.treeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeListView1.HeaderBeginColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.treeListView1.HeaderEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.treeListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.treeListView1.Location = new System.Drawing.Point(0, 0);
            this.treeListView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeListView1.MultiSelect = false;
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.OwnerDraw = true;
            this.treeListView1.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.treeListView1.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.treeListView1.SelectedBeginColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.treeListView1.SelectedEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(225)))), ((int)(((byte)(253)))));
            this.treeListView1.Size = new System.Drawing.Size(680, 451);
            this.treeListView1.Sorting = System.Windows.Forms.SortOrder.None;
            this.treeListView1.TabIndex = 0;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.Click += new System.EventHandler(this.treeListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "部件";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "排序";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "工位（工序）";
            this.columnHeader3.Width = 231;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "时间";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "分配人员";
            this.columnHeader5.Width = 353;
            // 
            // txPanelUser
            // 
            this.txPanelUser.BackColor = System.Drawing.Color.Transparent;
            this.txPanelUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelUser.Controls.Add(this.txGroupBox1);
            this.txPanelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.txPanelUser.Location = new System.Drawing.Point(941, 0);
            this.txPanelUser.Name = "txPanelUser";
            this.txPanelUser.Size = new System.Drawing.Size(437, 451);
            this.txPanelUser.TabIndex = 7;
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(437, 451);
            this.txGroupBox1.TabIndex = 0;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "人员：";
            this.txGroupBox1.TextMargin = 6;
            // 
            // txPanelLeft
            // 
            this.txPanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.txPanelLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelLeft.Controls.Add(this.tvEngineCode);
            this.txPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.txPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.txPanelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelLeft.Name = "txPanelLeft";
            this.txPanelLeft.Size = new System.Drawing.Size(261, 451);
            this.txPanelLeft.TabIndex = 4;
            // 
            // tvEngineCode
            // 
            this.tvEngineCode.BackColor = System.Drawing.SystemColors.Window;
            this.tvEngineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEngineCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tvEngineCode.Location = new System.Drawing.Point(0, 0);
            this.tvEngineCode.Margin = new System.Windows.Forms.Padding(4);
            this.tvEngineCode.Name = "tvEngineCode";
            this.tvEngineCode.Size = new System.Drawing.Size(261, 451);
            this.tvEngineCode.TabIndex = 0;
            this.tvEngineCode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEngineCode_AfterSelect);
            // 
            // btnHXD1BC5
            // 
            this.btnHXD1BC5.Location = new System.Drawing.Point(14, 13);
            this.btnHXD1BC5.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD1BC5.Name = "btnHXD1BC5";
            this.btnHXD1BC5.Size = new System.Drawing.Size(123, 37);
            this.btnHXD1BC5.TabIndex = 6;
            this.btnHXD1BC5.Text = "HXD1B-C5";
            this.btnHXD1BC5.UseVisualStyleBackColor = true;
            this.btnHXD1BC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD1C5
            // 
            this.btnHXD1C5.BackColor = System.Drawing.Color.Transparent;
            this.btnHXD1C5.Location = new System.Drawing.Point(447, 13);
            this.btnHXD1C5.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD1C5.Name = "btnHXD1C5";
            this.btnHXD1C5.Size = new System.Drawing.Size(123, 37);
            this.btnHXD1C5.TabIndex = 6;
            this.btnHXD1C5.Text = "HXD1-C5";
            this.btnHXD1C5.UseVisualStyleBackColor = false;
            this.btnHXD1C5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD3C5
            // 
            this.btnHXD3C5.BackColor = System.Drawing.Color.Transparent;
            this.btnHXD3C5.Location = new System.Drawing.Point(1088, 13);
            this.btnHXD3C5.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD3C5.Name = "btnHXD3C5";
            this.btnHXD3C5.Size = new System.Drawing.Size(123, 37);
            this.btnHXD3C5.TabIndex = 6;
            this.btnHXD3C5.Text = "HXD3-C5";
            this.btnHXD3C5.UseVisualStyleBackColor = false;
            this.btnHXD3C5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD3CC5
            // 
            this.btnHXD3CC5.Location = new System.Drawing.Point(877, 13);
            this.btnHXD3CC5.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD3CC5.Name = "btnHXD3CC5";
            this.btnHXD3CC5.Size = new System.Drawing.Size(123, 37);
            this.btnHXD3CC5.TabIndex = 6;
            this.btnHXD3CC5.Text = "HXD3C-C5";
            this.btnHXD3CC5.UseVisualStyleBackColor = true;
            this.btnHXD3CC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD3CC4
            // 
            this.btnHXD3CC4.Location = new System.Drawing.Point(664, 13);
            this.btnHXD3CC4.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD3CC4.Name = "btnHXD3CC4";
            this.btnHXD3CC4.Size = new System.Drawing.Size(123, 37);
            this.btnHXD3CC4.TabIndex = 6;
            this.btnHXD3CC4.Text = "HXD3C-C4";
            this.btnHXD3CC4.UseVisualStyleBackColor = true;
            this.btnHXD3CC4.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // txPanelBottom
            // 
            this.txPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.txPanelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelBottom.Controls.Add(this.btnAssign);
            this.txPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanelBottom.Location = new System.Drawing.Point(0, 559);
            this.txPanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelBottom.Name = "txPanelBottom";
            this.txPanelBottom.Size = new System.Drawing.Size(1378, 56);
            this.txPanelBottom.TabIndex = 5;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Gray;
            this.btnAssign.Enabled = false;
            this.btnAssign.Location = new System.Drawing.Point(8, 8);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(78, 37);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "分  配";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txPanelTop
            // 
            this.txPanelTop.BackColor = System.Drawing.Color.Transparent;
            this.txPanelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelTop.Controls.Add(this.txPanel1);
            this.txPanelTop.Controls.Add(this.txPanelBtn);
            this.txPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txPanelTop.Location = new System.Drawing.Point(0, 0);
            this.txPanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelTop.Name = "txPanelTop";
            this.txPanelTop.Size = new System.Drawing.Size(1378, 108);
            this.txPanelTop.TabIndex = 3;
            // 
            // txPanel1
            // 
            this.txPanel1.BackColor = System.Drawing.Color.Transparent;
            this.txPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel1.Controls.Add(this.label2);
            this.txPanel1.Controls.Add(this.label1);
            this.txPanel1.Controls.Add(this.txDateTimePicker1);
            this.txPanel1.Controls.Add(this.txCbbStatus);
            this.txPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel1.Location = new System.Drawing.Point(0, 0);
            this.txPanel1.Name = "txPanel1";
            this.txPanel1.Size = new System.Drawing.Size(1378, 45);
            this.txPanel1.TabIndex = 8;
            // 
            // txDateTimePicker1
            // 
            this.txDateTimePicker1.CalendarForeColor = System.Drawing.Color.Blue;
            this.txDateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txDateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))), ((int)(((byte)(237)))));
            this.txDateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.CadetBlue;
            this.txDateTimePicker1.Checked = false;
            this.txDateTimePicker1.Location = new System.Drawing.Point(416, 9);
            this.txDateTimePicker1.Name = "txDateTimePicker1";
            this.txDateTimePicker1.Size = new System.Drawing.Size(140, 26);
            this.txDateTimePicker1.TabIndex = 1;
            this.txDateTimePicker1.Value = null;
            // 
            // txCbbStatus
            // 
            this.txCbbStatus.FormattingEnabled = true;
            this.txCbbStatus.Items.AddRange(new object[] {
            "未分配",
            "已分配"});
            this.txCbbStatus.Location = new System.Drawing.Point(106, 10);
            this.txCbbStatus.Name = "txCbbStatus";
            this.txCbbStatus.Size = new System.Drawing.Size(123, 24);
            this.txCbbStatus.TabIndex = 0;
            this.txCbbStatus.Text = "未分配";
            // 
            // txPanelBtn
            // 
            this.txPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.txPanelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelBtn.Controls.Add(this.btnHXD1BC5);
            this.txPanelBtn.Controls.Add(this.btnHXD3C5);
            this.txPanelBtn.Controls.Add(this.btnHXD1C5);
            this.txPanelBtn.Controls.Add(this.btnHXD3CC5);
            this.txPanelBtn.Controls.Add(this.btnHXD1DC5);
            this.txPanelBtn.Controls.Add(this.btnHXD3CC4);
            this.txPanelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanelBtn.Location = new System.Drawing.Point(0, 45);
            this.txPanelBtn.Name = "txPanelBtn";
            this.txPanelBtn.Size = new System.Drawing.Size(1378, 63);
            this.txPanelBtn.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "分配状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "设备接收时间：";
            // 
            // TaskListForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CapitionLogo = null;
            this.ClientSize = new System.Drawing.Size(1384, 645);
            this.Controls.Add(this.txPanel3);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskListForm1";
            this.ResizeEnable = false;
            this.Text = "TaskListForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.txPanelCenter.ResumeLayout(false);
            this.txPanelTreeListView.ResumeLayout(false);
            this.txPanelUser.ResumeLayout(false);
            this.txPanelLeft.ResumeLayout(false);
            this.txPanelBottom.ResumeLayout(false);
            this.txPanelTop.ResumeLayout(false);
            this.txPanel1.ResumeLayout(false);
            this.txPanel1.PerformLayout();
            this.txPanelBtn.ResumeLayout(false);
            this.txPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHXD1DC5;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelCenter;
        private System.Windows.Forms.Button btnHXD1BC5;
        private System.Windows.Forms.Button btnHXD1C5;
        private System.Windows.Forms.Button btnHXD3C5;
        private System.Windows.Forms.Button btnHXD3CC5;
        private System.Windows.Forms.TreeView tvEngineCode;
        private System.Windows.Forms.Button btnHXD3CC4;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelBottom;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelLeft;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelTop;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel3;
        private TX.Framework.WindowUI.Controls.TreeListView treeListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelUser;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private System.Windows.Forms.Button btnAssign;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelTreeListView;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel1;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelBtn;
        private TX.Framework.WindowUI.Controls.TXComboBox txCbbStatus;
        private TX.Framework.WindowUI.Controls.TXDateTimePicker txDateTimePicker1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}