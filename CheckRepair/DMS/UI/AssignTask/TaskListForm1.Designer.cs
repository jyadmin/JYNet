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
            TX.Framework.WindowUI.Controls.TreeListViewItemCollection.TreeListViewItemCollectionComparer treeListViewItemCollectionComparer1 = new TX.Framework.WindowUI.Controls.TreeListViewItemCollection.TreeListViewItemCollectionComparer();
            this.btnHXD1DC5 = new System.Windows.Forms.Button();
            this.txPanelCenter = new TX.Framework.WindowUI.Controls.TXPanel();
            this.treeListView1 = new TX.Framework.WindowUI.Controls.TreeListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHXD1BC5 = new System.Windows.Forms.Button();
            this.btnHXD1C5 = new System.Windows.Forms.Button();
            this.btnHXD3C5 = new System.Windows.Forms.Button();
            this.btnHXD3CC5 = new System.Windows.Forms.Button();
            this.tvEngineCode = new System.Windows.Forms.TreeView();
            this.btnHXD3CC4 = new System.Windows.Forms.Button();
            this.txPanelBottom = new TX.Framework.WindowUI.Controls.TXPanel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txPanelLeft = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelTop = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelUser = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.txPanelCenter.SuspendLayout();
            this.txPanelBottom.SuspendLayout();
            this.txPanelLeft.SuspendLayout();
            this.txPanelTop.SuspendLayout();
            this.txPanel3.SuspendLayout();
            this.txPanelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHXD1DC5
            // 
            this.btnHXD1DC5.Location = new System.Drawing.Point(237, 11);
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
            this.txPanelCenter.Controls.Add(this.treeListView1);
            this.txPanelCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.txPanelCenter.Location = new System.Drawing.Point(261, 61);
            this.txPanelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelCenter.Name = "txPanelCenter";
            this.txPanelCenter.Size = new System.Drawing.Size(900, 498);
            this.txPanelCenter.TabIndex = 6;
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
            treeListViewItemCollectionComparer1.Column = 0;
            treeListViewItemCollectionComparer1.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeListView1.Comparer = treeListViewItemCollectionComparer1;
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
            this.treeListView1.Size = new System.Drawing.Size(900, 498);
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
            // btnHXD1BC5
            // 
            this.btnHXD1BC5.Location = new System.Drawing.Point(32, 11);
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
            this.btnHXD1C5.Location = new System.Drawing.Point(449, 11);
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
            this.btnHXD3C5.Location = new System.Drawing.Point(1088, 9);
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
            this.btnHXD3CC5.Location = new System.Drawing.Point(872, 11);
            this.btnHXD3CC5.Margin = new System.Windows.Forms.Padding(4);
            this.btnHXD3CC5.Name = "btnHXD3CC5";
            this.btnHXD3CC5.Size = new System.Drawing.Size(123, 37);
            this.btnHXD3CC5.TabIndex = 6;
            this.btnHXD3CC5.Text = "HXD3C-C5";
            this.btnHXD3CC5.UseVisualStyleBackColor = true;
            this.btnHXD3CC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // tvEngineCode
            // 
            this.tvEngineCode.BackColor = System.Drawing.SystemColors.Window;
            this.tvEngineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEngineCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tvEngineCode.Location = new System.Drawing.Point(0, 0);
            this.tvEngineCode.Margin = new System.Windows.Forms.Padding(4);
            this.tvEngineCode.Name = "tvEngineCode";
            this.tvEngineCode.Size = new System.Drawing.Size(261, 554);
            this.tvEngineCode.TabIndex = 0;
            this.tvEngineCode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEngineCode_AfterSelect);
            // 
            // btnHXD3CC4
            // 
            this.btnHXD3CC4.Location = new System.Drawing.Point(665, 9);
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
            this.txPanelBottom.Location = new System.Drawing.Point(261, 559);
            this.txPanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelBottom.Name = "txPanelBottom";
            this.txPanelBottom.Size = new System.Drawing.Size(1117, 56);
            this.txPanelBottom.TabIndex = 5;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAssign.Location = new System.Drawing.Point(8, 8);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(78, 37);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "分  配";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txPanelLeft
            // 
            this.txPanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.txPanelLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelLeft.Controls.Add(this.tvEngineCode);
            this.txPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.txPanelLeft.Location = new System.Drawing.Point(0, 61);
            this.txPanelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelLeft.Name = "txPanelLeft";
            this.txPanelLeft.Size = new System.Drawing.Size(261, 554);
            this.txPanelLeft.TabIndex = 4;
            // 
            // txPanelTop
            // 
            this.txPanelTop.BackColor = System.Drawing.Color.Transparent;
            this.txPanelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelTop.Controls.Add(this.btnHXD1BC5);
            this.txPanelTop.Controls.Add(this.btnHXD1C5);
            this.txPanelTop.Controls.Add(this.btnHXD3C5);
            this.txPanelTop.Controls.Add(this.btnHXD3CC5);
            this.txPanelTop.Controls.Add(this.btnHXD3CC4);
            this.txPanelTop.Controls.Add(this.btnHXD1DC5);
            this.txPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txPanelTop.Location = new System.Drawing.Point(0, 0);
            this.txPanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelTop.Name = "txPanelTop";
            this.txPanelTop.Size = new System.Drawing.Size(1378, 61);
            this.txPanelTop.TabIndex = 3;
            // 
            // txPanel3
            // 
            this.txPanel3.BackColor = System.Drawing.Color.Transparent;
            this.txPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel3.Controls.Add(this.txPanelUser);
            this.txPanel3.Controls.Add(this.txPanelCenter);
            this.txPanel3.Controls.Add(this.txPanelBottom);
            this.txPanel3.Controls.Add(this.txPanelLeft);
            this.txPanel3.Controls.Add(this.txPanelTop);
            this.txPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel3.Location = new System.Drawing.Point(3, 27);
            this.txPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.txPanel3.Name = "txPanel3";
            this.txPanel3.Size = new System.Drawing.Size(1378, 615);
            this.txPanel3.TabIndex = 5;
            // 
            // txPanelUser
            // 
            this.txPanelUser.BackColor = System.Drawing.Color.Transparent;
            this.txPanelUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelUser.Controls.Add(this.txGroupBox1);
            this.txPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelUser.Location = new System.Drawing.Point(1161, 61);
            this.txPanelUser.Name = "txPanelUser";
            this.txPanelUser.Size = new System.Drawing.Size(217, 498);
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
            this.txGroupBox1.Size = new System.Drawing.Size(217, 498);
            this.txGroupBox1.TabIndex = 0;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "人员：";
            this.txGroupBox1.TextMargin = 6;
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
            this.txPanelBottom.ResumeLayout(false);
            this.txPanelLeft.ResumeLayout(false);
            this.txPanelTop.ResumeLayout(false);
            this.txPanel3.ResumeLayout(false);
            this.txPanelUser.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAssign;
    }
}