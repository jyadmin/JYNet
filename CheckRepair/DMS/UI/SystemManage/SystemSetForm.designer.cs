namespace DMS.UI.SystemManage
{
    partial class SystemSetForm
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
            this.statustrip = new System.Windows.Forms.StatusStrip();
            this.menuItem = new System.Windows.Forms.MenuStrip();
            this.tv = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // statustrip
            // 
            this.statustrip.Location = new System.Drawing.Point(3, 864);
            this.statustrip.Name = "statustrip";
            this.statustrip.Size = new System.Drawing.Size(1104, 22);
            this.statustrip.TabIndex = 1;
            this.statustrip.Text = "statusStrip1";
            // 
            // menuItem
            // 
            this.menuItem.Location = new System.Drawing.Point(3, 27);
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(1104, 24);
            this.menuItem.TabIndex = 3;
            this.menuItem.Text = "menuStrip1";
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv.Location = new System.Drawing.Point(3, 51);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(199, 813);
            this.tv.TabIndex = 6;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(202, 51);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 813);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // toolstrip
            // 
            this.toolstrip.Location = new System.Drawing.Point(205, 51);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(902, 25);
            this.toolstrip.TabIndex = 8;
            this.toolstrip.Text = "toolStrip1";
            // 
            // SystemSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 889);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.statustrip);
            this.Controls.Add(this.menuItem);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuItem;
            this.Name = "SystemSetForm";
            this.ShowIcon = false;
            this.Text = "系统设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statustrip;
        private System.Windows.Forms.MenuStrip menuItem;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolstrip;
    }
}

