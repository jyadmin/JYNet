namespace MainPage
{
    partial class MainPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SystemSettings = new System.Windows.Forms.Button();
            this.AssignTask = new System.Windows.Forms.Button();
            this.DataSearch = new System.Windows.Forms.Button();
            this.MutualInspection = new System.Windows.Forms.Button();
            this.TeamMien = new System.Windows.Forms.Button();
            this.MessageConvey = new System.Windows.Forms.Button();
            this.AffairOpen = new System.Windows.Forms.Button();
            this.RateOfProgress = new System.Windows.Forms.Button();
            this.Eight_S_Manage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(542, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // SystemSettings
            // 
            this.SystemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(53)))), ((int)(((byte)(42)))));
            this.SystemSettings.FlatAppearance.BorderSize = 0;
            this.SystemSettings.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SystemSettings.ForeColor = System.Drawing.Color.White;
            this.SystemSettings.Location = new System.Drawing.Point(453, 83);
            this.SystemSettings.Name = "SystemSettings";
            this.SystemSettings.Size = new System.Drawing.Size(110, 114);
            this.SystemSettings.TabIndex = 0;
            this.SystemSettings.Text = "系统设置";
            this.SystemSettings.UseVisualStyleBackColor = false;
            this.SystemSettings.Click += new System.EventHandler(this.button_Click);
            // 
            // AssignTask
            // 
            this.AssignTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(134)))), ((int)(((byte)(240)))));
            this.AssignTask.FlatAppearance.BorderSize = 0;
            this.AssignTask.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssignTask.Location = new System.Drawing.Point(103, 82);
            this.AssignTask.Name = "AssignTask";
            this.AssignTask.Size = new System.Drawing.Size(226, 114);
            this.AssignTask.TabIndex = 0;
            this.AssignTask.Text = "工长派工";
            this.AssignTask.UseVisualStyleBackColor = false;
            this.AssignTask.Click += new System.EventHandler(this.button_Click);
            // 
            // DataSearch
            // 
            this.DataSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(82)))));
            this.DataSearch.FlatAppearance.BorderSize = 0;
            this.DataSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSearch.ForeColor = System.Drawing.Color.White;
            this.DataSearch.Location = new System.Drawing.Point(335, 83);
            this.DataSearch.Name = "DataSearch";
            this.DataSearch.Size = new System.Drawing.Size(112, 114);
            this.DataSearch.TabIndex = 0;
            this.DataSearch.Text = "数据查询统计";
            this.DataSearch.UseVisualStyleBackColor = false;
            this.DataSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // MutualInspection
            // 
            this.MutualInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(209)))), ((int)(((byte)(219)))));
            this.MutualInspection.FlatAppearance.BorderSize = 0;
            this.MutualInspection.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MutualInspection.ForeColor = System.Drawing.Color.White;
            this.MutualInspection.Location = new System.Drawing.Point(105, 202);
            this.MutualInspection.Name = "MutualInspection";
            this.MutualInspection.Size = new System.Drawing.Size(224, 114);
            this.MutualInspection.TabIndex = 0;
            this.MutualInspection.Text = "互  检";
            this.MutualInspection.UseVisualStyleBackColor = false;
            this.MutualInspection.Click += new System.EventHandler(this.button_Click);
            // 
            // TeamMien
            // 
            this.TeamMien.BackColor = System.Drawing.Color.Red;
            this.TeamMien.FlatAppearance.BorderSize = 0;
            this.TeamMien.Font = new System.Drawing.Font("宋体", 15F);
            this.TeamMien.ForeColor = System.Drawing.Color.White;
            this.TeamMien.Location = new System.Drawing.Point(105, 322);
            this.TeamMien.Name = "TeamMien";
            this.TeamMien.Size = new System.Drawing.Size(110, 114);
            this.TeamMien.TabIndex = 0;
            this.TeamMien.Text = "班组风采";
            this.TeamMien.UseVisualStyleBackColor = false;
            this.TeamMien.Click += new System.EventHandler(this.button_Click);
            // 
            // MessageConvey
            // 
            this.MessageConvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.MessageConvey.FlatAppearance.BorderSize = 0;
            this.MessageConvey.Font = new System.Drawing.Font("宋体", 15F);
            this.MessageConvey.ForeColor = System.Drawing.Color.White;
            this.MessageConvey.Location = new System.Drawing.Point(219, 322);
            this.MessageConvey.Name = "MessageConvey";
            this.MessageConvey.Size = new System.Drawing.Size(110, 114);
            this.MessageConvey.TabIndex = 0;
            this.MessageConvey.Text = "文电传达";
            this.MessageConvey.UseVisualStyleBackColor = false;
            this.MessageConvey.Click += new System.EventHandler(this.button_Click);
            // 
            // AffairOpen
            // 
            this.AffairOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(85)))), ((int)(((byte)(47)))));
            this.AffairOpen.FlatAppearance.BorderSize = 0;
            this.AffairOpen.Font = new System.Drawing.Font("宋体", 15F);
            this.AffairOpen.ForeColor = System.Drawing.Color.White;
            this.AffairOpen.Location = new System.Drawing.Point(335, 322);
            this.AffairOpen.Name = "AffairOpen";
            this.AffairOpen.Size = new System.Drawing.Size(112, 114);
            this.AffairOpen.TabIndex = 0;
            this.AffairOpen.Text = "事务公开";
            this.AffairOpen.UseVisualStyleBackColor = false;
            this.AffairOpen.Click += new System.EventHandler(this.button_Click);
            // 
            // RateOfProgress
            // 
            this.RateOfProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
            this.RateOfProgress.FlatAppearance.BorderSize = 0;
            this.RateOfProgress.Font = new System.Drawing.Font("宋体", 15F);
            this.RateOfProgress.ForeColor = System.Drawing.Color.White;
            this.RateOfProgress.Location = new System.Drawing.Point(335, 202);
            this.RateOfProgress.Name = "RateOfProgress";
            this.RateOfProgress.Size = new System.Drawing.Size(226, 114);
            this.RateOfProgress.TabIndex = 0;
            this.RateOfProgress.Text = "实时进度";
            this.RateOfProgress.UseVisualStyleBackColor = false;
            this.RateOfProgress.Click += new System.EventHandler(this.button_Click);
            // 
            // Eight_S_Manage
            // 
            this.Eight_S_Manage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Eight_S_Manage.FlatAppearance.BorderSize = 0;
            this.Eight_S_Manage.Font = new System.Drawing.Font("宋体", 15F);
            this.Eight_S_Manage.ForeColor = System.Drawing.Color.White;
            this.Eight_S_Manage.Location = new System.Drawing.Point(451, 323);
            this.Eight_S_Manage.Name = "Eight_S_Manage";
            this.Eight_S_Manage.Size = new System.Drawing.Size(110, 114);
            this.Eight_S_Manage.TabIndex = 0;
            this.Eight_S_Manage.Text = "8S管理";
            this.Eight_S_Manage.UseVisualStyleBackColor = false;
            this.Eight_S_Manage.Click += new System.EventHandler(this.button_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MutualInspection);
            this.Controls.Add(this.DataSearch);
            this.Controls.Add(this.TeamMien);
            this.Controls.Add(this.Eight_S_Manage);
            this.Controls.Add(this.MessageConvey);
            this.Controls.Add(this.AffairOpen);
            this.Controls.Add(this.RateOfProgress);
            this.Controls.Add(this.AssignTask);
            this.Controls.Add(this.SystemSettings);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(500, 200);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "检 修 系 统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SystemSettings;
        private System.Windows.Forms.Button AssignTask;
        private System.Windows.Forms.Button DataSearch;
        private System.Windows.Forms.Button MutualInspection;
        private System.Windows.Forms.Button TeamMien;
        private System.Windows.Forms.Button MessageConvey;
        private System.Windows.Forms.Button AffairOpen;
        private System.Windows.Forms.Button RateOfProgress;
        private System.Windows.Forms.Button Eight_S_Manage;

    }
}

