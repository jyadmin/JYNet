namespace DMS.UI.AssignTask
{
    partial class TaskListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelCenter = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelBottom = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelLeft = new TX.Framework.WindowUI.Controls.TXPanel();
            this.tvEngineCode = new System.Windows.Forms.TreeView();
            this.txPanelTop = new TX.Framework.WindowUI.Controls.TXPanel();
            this.dgvTemplateMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LastCheckerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHXD1DC5 = new System.Windows.Forms.Button();
            this.btnHXD1BC5 = new System.Windows.Forms.Button();
            this.btnHXD3CC4 = new System.Windows.Forms.Button();
            this.btnHXD1C5 = new System.Windows.Forms.Button();
            this.btnHXD3CC5 = new System.Windows.Forms.Button();
            this.btnHXD3C5 = new System.Windows.Forms.Button();
            this.txPanel3.SuspendLayout();
            this.txPanelCenter.SuspendLayout();
            this.txPanelLeft.SuspendLayout();
            this.txPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplateMain)).BeginInit();
            this.SuspendLayout();
            // 
            // txPanel3
            // 
            this.txPanel3.BackColor = System.Drawing.Color.Transparent;
            this.txPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel3.Controls.Add(this.txPanelCenter);
            this.txPanel3.Controls.Add(this.txPanelBottom);
            this.txPanel3.Controls.Add(this.txPanelLeft);
            this.txPanel3.Controls.Add(this.txPanelTop);
            this.txPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel3.Location = new System.Drawing.Point(3, 27);
            this.txPanel3.Name = "txPanel3";
            this.txPanel3.Size = new System.Drawing.Size(1305, 639);
            this.txPanel3.TabIndex = 4;
            // 
            // txPanelCenter
            // 
            this.txPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.txPanelCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelCenter.Controls.Add(this.dgvTemplateMain);
            this.txPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelCenter.Location = new System.Drawing.Point(196, 46);
            this.txPanelCenter.Name = "txPanelCenter";
            this.txPanelCenter.Size = new System.Drawing.Size(1109, 551);
            this.txPanelCenter.TabIndex = 6;
            // 
            // txPanelBottom
            // 
            this.txPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.txPanelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanelBottom.Location = new System.Drawing.Point(196, 597);
            this.txPanelBottom.Name = "txPanelBottom";
            this.txPanelBottom.Size = new System.Drawing.Size(1109, 42);
            this.txPanelBottom.TabIndex = 5;
            // 
            // txPanelLeft
            // 
            this.txPanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.txPanelLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelLeft.Controls.Add(this.tvEngineCode);
            this.txPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.txPanelLeft.Location = new System.Drawing.Point(0, 46);
            this.txPanelLeft.Name = "txPanelLeft";
            this.txPanelLeft.Size = new System.Drawing.Size(196, 593);
            this.txPanelLeft.TabIndex = 4;
            // 
            // tvEngineCode
            // 
            this.tvEngineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEngineCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tvEngineCode.Location = new System.Drawing.Point(0, 0);
            this.tvEngineCode.Name = "tvEngineCode";
            this.tvEngineCode.Size = new System.Drawing.Size(196, 593);
            this.tvEngineCode.TabIndex = 0;
            this.tvEngineCode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEngineCode_AfterSelect);
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
            this.txPanelTop.Name = "txPanelTop";
            this.txPanelTop.Size = new System.Drawing.Size(1305, 46);
            this.txPanelTop.TabIndex = 3;
            // 
            // dgvTemplateMain
            // 
            this.dgvTemplateMain.AllowUserToAddRows = false;
            this.dgvTemplateMain.AllowUserToDeleteRows = false;
            this.dgvTemplateMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemplateMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTemplateMain.ColumnHeadersHeight = 32;
            this.dgvTemplateMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTemplateMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.LastCheckerCode});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTemplateMain.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTemplateMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTemplateMain.Location = new System.Drawing.Point(0, 0);
            this.dgvTemplateMain.MultiSelect = false;
            this.dgvTemplateMain.Name = "dgvTemplateMain";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemplateMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvTemplateMain.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTemplateMain.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTemplateMain.RowTemplate.Height = 32;
            this.dgvTemplateMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemplateMain.Size = new System.Drawing.Size(1109, 551);
            this.dgvTemplateMain.TabIndex = 0;
            this.dgvTemplateMain.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "部件";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "工位（工序）名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "操作时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "操作人员";
            this.Column4.Name = "Column4";
            this.Column4.Width = 84;
            // 
            // LastCheckerCode
            // 
            this.LastCheckerCode.HeaderText = "上次检查人编号";
            this.LastCheckerCode.Name = "LastCheckerCode";
            this.LastCheckerCode.ReadOnly = true;
            this.LastCheckerCode.Visible = false;
            // 
            // btnHXD1DC5
            // 
            this.btnHXD1DC5.Location = new System.Drawing.Point(178, 8);
            this.btnHXD1DC5.Name = "btnHXD1DC5";
            this.btnHXD1DC5.Size = new System.Drawing.Size(92, 28);
            this.btnHXD1DC5.TabIndex = 6;
            this.btnHXD1DC5.Text = "HXD1D-C5";
            this.btnHXD1DC5.UseVisualStyleBackColor = true;
            this.btnHXD1DC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD1BC5
            // 
            this.btnHXD1BC5.Location = new System.Drawing.Point(24, 8);
            this.btnHXD1BC5.Name = "btnHXD1BC5";
            this.btnHXD1BC5.Size = new System.Drawing.Size(92, 28);
            this.btnHXD1BC5.TabIndex = 6;
            this.btnHXD1BC5.Text = "HXD1B-C5";
            this.btnHXD1BC5.UseVisualStyleBackColor = true;
            this.btnHXD1BC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD3CC4
            // 
            this.btnHXD3CC4.Location = new System.Drawing.Point(499, 7);
            this.btnHXD3CC4.Name = "btnHXD3CC4";
            this.btnHXD3CC4.Size = new System.Drawing.Size(92, 28);
            this.btnHXD3CC4.TabIndex = 6;
            this.btnHXD3CC4.Text = "HXD3C-C4";
            this.btnHXD3CC4.UseVisualStyleBackColor = true;
            this.btnHXD3CC4.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD1C5
            // 
            this.btnHXD1C5.Location = new System.Drawing.Point(337, 8);
            this.btnHXD1C5.Name = "btnHXD1C5";
            this.btnHXD1C5.Size = new System.Drawing.Size(92, 28);
            this.btnHXD1C5.TabIndex = 6;
            this.btnHXD1C5.Text = "HXD1-C5";
            this.btnHXD1C5.UseVisualStyleBackColor = true;
            this.btnHXD1C5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD3CC5
            // 
            this.btnHXD3CC5.Location = new System.Drawing.Point(654, 8);
            this.btnHXD3CC5.Name = "btnHXD3CC5";
            this.btnHXD3CC5.Size = new System.Drawing.Size(92, 28);
            this.btnHXD3CC5.TabIndex = 6;
            this.btnHXD3CC5.Text = "HXD3C-C5";
            this.btnHXD3CC5.UseVisualStyleBackColor = true;
            this.btnHXD3CC5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // btnHXD3C5
            // 
            this.btnHXD3C5.BackColor = System.Drawing.Color.Transparent;
            this.btnHXD3C5.Location = new System.Drawing.Point(816, 7);
            this.btnHXD3C5.Name = "btnHXD3C5";
            this.btnHXD3C5.Size = new System.Drawing.Size(92, 28);
            this.btnHXD3C5.TabIndex = 6;
            this.btnHXD3C5.Text = "HXD3-C5";
            this.btnHXD3C5.UseVisualStyleBackColor = false;
            this.btnHXD3C5.Click += new System.EventHandler(this.btnEngineType_Click);
            // 
            // TaskListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CapitionLogo = null;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1311, 669);
            this.Controls.Add(this.txPanel3);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TaskListForm";
            this.Text = "任务列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.txPanel3.ResumeLayout(false);
            this.txPanelCenter.ResumeLayout(false);
            this.txPanelLeft.ResumeLayout(false);
            this.txPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplateMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXPanel txPanel3;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelTop;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelLeft;
        private System.Windows.Forms.TreeView tvEngineCode;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelCenter;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelBottom;
        private System.Windows.Forms.DataGridView dgvTemplateMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCheckerCode;
        private System.Windows.Forms.Button btnHXD1DC5;
        private System.Windows.Forms.Button btnHXD1BC5;
        private System.Windows.Forms.Button btnHXD1C5;
        private System.Windows.Forms.Button btnHXD3CC5;
        private System.Windows.Forms.Button btnHXD3CC4;
        private System.Windows.Forms.Button btnHXD3C5;

    }
}