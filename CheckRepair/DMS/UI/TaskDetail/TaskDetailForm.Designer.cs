namespace DMS.UI.TaskDetail
{
    partial class TaskDetailForm
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
            this.txPaneltOP = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelRight = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelLeft = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelBottom = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelMain = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelCenter = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txButtonFinished = new TX.Framework.WindowUI.Controls.TXButton();
            this.txPanelBottom.SuspendLayout();
            this.txPanelMain.SuspendLayout();
            this.txPanelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txPaneltOP
            // 
            this.txPaneltOP.BackColor = System.Drawing.Color.Transparent;
            this.txPaneltOP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPaneltOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txPaneltOP.Location = new System.Drawing.Point(0, 0);
            this.txPaneltOP.Margin = new System.Windows.Forms.Padding(4);
            this.txPaneltOP.Name = "txPaneltOP";
            this.txPaneltOP.Size = new System.Drawing.Size(1518, 53);
            this.txPaneltOP.TabIndex = 0;
            // 
            // txPanelRight
            // 
            this.txPanelRight.BackColor = System.Drawing.Color.Transparent;
            this.txPanelRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelRight.Location = new System.Drawing.Point(204, 0);
            this.txPanelRight.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelRight.Name = "txPanelRight";
            this.txPanelRight.Size = new System.Drawing.Size(1314, 522);
            this.txPanelRight.TabIndex = 1;
            // 
            // txPanelLeft
            // 
            this.txPanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.txPanelLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.txPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.txPanelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelLeft.Name = "txPanelLeft";
            this.txPanelLeft.Size = new System.Drawing.Size(204, 522);
            this.txPanelLeft.TabIndex = 0;
            // 
            // txPanelBottom
            // 
            this.txPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.txPanelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelBottom.Controls.Add(this.txButtonFinished);
            this.txPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanelBottom.Location = new System.Drawing.Point(0, 575);
            this.txPanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelBottom.Name = "txPanelBottom";
            this.txPanelBottom.Size = new System.Drawing.Size(1518, 60);
            this.txPanelBottom.TabIndex = 0;
            // 
            // txPanelMain
            // 
            this.txPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.txPanelMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelMain.Controls.Add(this.txPanelCenter);
            this.txPanelMain.Controls.Add(this.txPaneltOP);
            this.txPanelMain.Controls.Add(this.txPanelBottom);
            this.txPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelMain.Location = new System.Drawing.Point(3, 27);
            this.txPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelMain.Name = "txPanelMain";
            this.txPanelMain.Size = new System.Drawing.Size(1518, 635);
            this.txPanelMain.TabIndex = 2;
            // 
            // txPanelCenter
            // 
            this.txPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.txPanelCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelCenter.Controls.Add(this.txPanelRight);
            this.txPanelCenter.Controls.Add(this.txPanelLeft);
            this.txPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelCenter.Location = new System.Drawing.Point(0, 53);
            this.txPanelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelCenter.Name = "txPanelCenter";
            this.txPanelCenter.Size = new System.Drawing.Size(1518, 522);
            this.txPanelCenter.TabIndex = 2;
            // 
            // txButtonFinished
            // 
            this.txButtonFinished.Enabled = false;
            this.txButtonFinished.Image = null;
            this.txButtonFinished.Location = new System.Drawing.Point(12, 7);
            this.txButtonFinished.Name = "txButtonFinished";
            this.txButtonFinished.Size = new System.Drawing.Size(113, 40);
            this.txButtonFinished.TabIndex = 0;
            this.txButtonFinished.Text = "确 认 完 成";
            this.txButtonFinished.UseVisualStyleBackColor = true;
            this.txButtonFinished.Click += new System.EventHandler(this.txButtonFinished_Click);
            // 
            // TaskDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CapitionLogo = null;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1524, 665);
            this.Controls.Add(this.txPanelMain);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskDetailForm";
            this.ResizeEnable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.txPanelBottom.ResumeLayout(false);
            this.txPanelMain.ResumeLayout(false);
            this.txPanelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXPanel txPaneltOP;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelRight;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelBottom;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelMain;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelLeft;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelCenter;
        private TX.Framework.WindowUI.Controls.TXButton txButtonFinished;

    }
}