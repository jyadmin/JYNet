namespace DMS.UI.FileManage
{
    partial class FileManageMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFileManange = new System.Windows.Forms.DataGridView();
            this.文件名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上传时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.查看 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newFile = new TX.Framework.WindowUI.Controls.TXButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileManange)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFileManange
            // 
            this.dgvFileManange.AllowUserToAddRows = false;
            this.dgvFileManange.AllowUserToDeleteRows = false;
            this.dgvFileManange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFileManange.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileManange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileManange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileManange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.文件名称,
            this.上传时间,
            this.查看,
            this.删除});
            this.dgvFileManange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileManange.Location = new System.Drawing.Point(0, 0);
            this.dgvFileManange.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFileManange.Name = "dgvFileManange";
            this.dgvFileManange.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileManange.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFileManange.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFileManange.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFileManange.RowTemplate.Height = 23;
            this.dgvFileManange.Size = new System.Drawing.Size(929, 481);
            this.dgvFileManange.TabIndex = 0;
            this.dgvFileManange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAffairsOpen_CellContentClick);
            // 
            // 文件名称
            // 
            this.文件名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.文件名称.FillWeight = 45F;
            this.文件名称.HeaderText = "文件名称";
            this.文件名称.Name = "文件名称";
            this.文件名称.ReadOnly = true;
            this.文件名称.ToolTipText = "文件名称";
            // 
            // 上传时间
            // 
            this.上传时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.上传时间.FillWeight = 35F;
            this.上传时间.HeaderText = "上传时间";
            this.上传时间.Name = "上传时间";
            this.上传时间.ReadOnly = true;
            // 
            // 查看
            // 
            this.查看.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.查看.FillWeight = 10F;
            this.查看.HeaderText = "查看";
            this.查看.Name = "查看";
            this.查看.ReadOnly = true;
            this.查看.Text = "查看";
            this.查看.UseColumnTextForButtonValue = true;
            // 
            // 删除
            // 
            this.删除.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.删除.FillWeight = 10F;
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.ReadOnly = true;
            this.删除.Text = "删除";
            this.删除.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 45);
            this.panel1.TabIndex = 1;
            // 
            // newFile
            // 
            this.newFile.Image = null;
            this.newFile.Location = new System.Drawing.Point(4, 4);
            this.newFile.Margin = new System.Windows.Forms.Padding(4);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(133, 37);
            this.newFile.TabIndex = 2;
            this.newFile.Text = "上传文件";
            this.newFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFileManange);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 481);
            this.panel2.TabIndex = 2;
            // 
            // FileManageMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CapitionLogo = null;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(935, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileManageMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileManange)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileManange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private TX.Framework.WindowUI.Controls.TXButton newFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文件名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上传时间;
        private System.Windows.Forms.DataGridViewButtonColumn 查看;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;

    }
}