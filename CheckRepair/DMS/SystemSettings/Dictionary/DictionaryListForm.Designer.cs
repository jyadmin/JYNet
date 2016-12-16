namespace DMS
{
    partial class DictionaryListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cDMSDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkRepairDBDataSet = new DMS.CheckRepairDBDataSet();
            this.c_DMS_DictionaryTableAdapter = new DMS.CheckRepairDBDataSetTableAdapters.C_DMS_DictionaryTableAdapter();
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txToolStrip1 = new TX.Framework.WindowUI.Controls.TXToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.DicdataSearchToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.txPanel2 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPager1 = new TX.Framework.WindowUI.Controls.TXPager();
            this.txPanel1 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.DicDataGridView = new System.Windows.Forms.DataGridView();
            this.txPanel4 = new TX.Framework.WindowUI.Controls.TXPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cDMSDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRepairDBDataSet)).BeginInit();
            this.txPanel3.SuspendLayout();
            this.txToolStrip1.SuspendLayout();
            this.txPanel2.SuspendLayout();
            this.txPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DicDataGridView)).BeginInit();
            this.txPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDMSDictionaryBindingSource
            // 
            this.cDMSDictionaryBindingSource.DataMember = "C_DMS_Dictionary";
            this.cDMSDictionaryBindingSource.DataSource = this.checkRepairDBDataSet;
            // 
            // checkRepairDBDataSet
            // 
            this.checkRepairDBDataSet.DataSetName = "CheckRepairDBDataSet";
            this.checkRepairDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_DMS_DictionaryTableAdapter
            // 
            this.c_DMS_DictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // txPanel3
            // 
            this.txPanel3.BackColor = System.Drawing.Color.Transparent;
            this.txPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel3.Controls.Add(this.txToolStrip1);
            this.txPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.txPanel3.Location = new System.Drawing.Point(0, 0);
            this.txPanel3.Name = "txPanel3";
            this.txPanel3.Size = new System.Drawing.Size(593, 40);
            this.txPanel3.TabIndex = 5;
            // 
            // txToolStrip1
            // 
            this.txToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txToolStrip1.BeginBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txToolStrip1.EndBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbUpdate,
            this.tsbDelete,
            this.DicdataSearchToolStripLabel,
            this.toolStripTextBox1,
            this.tsbSearch});
            this.txToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.txToolStrip1.Name = "txToolStrip1";
            this.txToolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.txToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.txToolStrip1.Size = new System.Drawing.Size(593, 40);
            this.txToolStrip1.TabIndex = 3;
            this.txToolStrip1.Text = "txToolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(62, 37);
            this.tsbNew.Text = "新增";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Update_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(62, 37);
            this.tsbUpdate.Text = "修改";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbNew_Update_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(62, 37);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // DicdataSearchToolStripLabel
            // 
            this.DicdataSearchToolStripLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DicdataSearchToolStripLabel.Name = "DicdataSearchToolStripLabel";
            this.DicdataSearchToolStripLabel.Size = new System.Drawing.Size(90, 37);
            this.DicdataSearchToolStripLabel.Text = "查询条件：";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 40);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(62, 37);
            this.tsbSearch.Text = "查询";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // txPanel2
            // 
            this.txPanel2.BackColor = System.Drawing.Color.Transparent;
            this.txPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel2.Controls.Add(this.txPager1);
            this.txPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanel2.Location = new System.Drawing.Point(0, 448);
            this.txPanel2.Name = "txPanel2";
            this.txPanel2.Size = new System.Drawing.Size(593, 36);
            this.txPanel2.TabIndex = 4;
            // 
            // txPager1
            // 
            this.txPager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txPager1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPager1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txPager1.Location = new System.Drawing.Point(0, 0);
            this.txPager1.Name = "txPager1";
            this.txPager1.PageSize = 20;
            this.txPager1.Size = new System.Drawing.Size(593, 36);
            this.txPager1.TabIndex = 0;
            this.txPager1.Total = 0D;
            this.txPager1.OnPaging += new System.EventHandler<TX.Framework.WindowUI.Controls.PagerEventArgs>(this.txPager1_OnPaging);
            // 
            // txPanel1
            // 
            this.txPanel1.BackColor = System.Drawing.Color.Transparent;
            this.txPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel1.Controls.Add(this.DicDataGridView);
            this.txPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel1.Location = new System.Drawing.Point(0, 40);
            this.txPanel1.Name = "txPanel1";
            this.txPanel1.Size = new System.Drawing.Size(593, 408);
            this.txPanel1.TabIndex = 3;
            // 
            // DicDataGridView
            // 
            this.DicDataGridView.AllowUserToAddRows = false;
            this.DicDataGridView.AllowUserToDeleteRows = false;
            this.DicDataGridView.AllowUserToOrderColumns = true;
            this.DicDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DicDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DicDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DicDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DicDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DicDataGridView.Name = "DicDataGridView";
            this.DicDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DicDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DicDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DicDataGridView.RowTemplate.Height = 23;
            this.DicDataGridView.Size = new System.Drawing.Size(593, 408);
            this.DicDataGridView.TabIndex = 2;
            // 
            // txPanel4
            // 
            this.txPanel4.BackColor = System.Drawing.Color.Transparent;
            this.txPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel4.Controls.Add(this.txPanel1);
            this.txPanel4.Controls.Add(this.txPanel2);
            this.txPanel4.Controls.Add(this.txPanel3);
            this.txPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel4.Location = new System.Drawing.Point(1, 1);
            this.txPanel4.Name = "txPanel4";
            this.txPanel4.Size = new System.Drawing.Size(593, 484);
            this.txPanel4.TabIndex = 6;
            // 
            // DictionaryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderWidth = 1;
            this.CapitionLogo = null;
            this.CaptionHeight = 1;
            this.ClientSize = new System.Drawing.Size(595, 486);
            this.ControlBox = false;
            this.Controls.Add(this.txPanel4);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DictionaryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.cDMSDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRepairDBDataSet)).EndInit();
            this.txPanel3.ResumeLayout(false);
            this.txPanel3.PerformLayout();
            this.txToolStrip1.ResumeLayout(false);
            this.txToolStrip1.PerformLayout();
            this.txPanel2.ResumeLayout(false);
            this.txPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DicDataGridView)).EndInit();
            this.txPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DicDataGridView;
        private CheckRepairDBDataSet checkRepairDBDataSet;
        private System.Windows.Forms.BindingSource cDMSDictionaryBindingSource;
        private CheckRepairDBDataSetTableAdapters.C_DMS_DictionaryTableAdapter c_DMS_DictionaryTableAdapter;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel1;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel2;
        private TX.Framework.WindowUI.Controls.TXPager txPager1;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel3;
        private TX.Framework.WindowUI.Controls.TXToolStrip txToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripLabel DicdataSearchToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripButton tsbSearch;
        public System.Windows.Forms.ToolStripButton tsbNew;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel4;
    }
}