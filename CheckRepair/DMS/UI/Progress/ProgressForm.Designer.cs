namespace DMS.UI.Progress
{
    partial class ProgressForm
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
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelCenter = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelRight = new TX.Framework.WindowUI.Controls.TXPanel();
            this.panelDetailProgress = new System.Windows.Forms.Panel();
            this.panelMainProgress = new System.Windows.Forms.Panel();
            this.txPanelLeft = new TX.Framework.WindowUI.Controls.TXPanel();
            this.tvEngineCode = new System.Windows.Forms.TreeView();
            this.txPanelBottom = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanelTop = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPanel1 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDateTimePicker2 = new TX.Framework.WindowUI.Controls.TXDateTimePicker();
            this.txDateTimePicker1 = new TX.Framework.WindowUI.Controls.TXDateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txPanel3.SuspendLayout();
            this.txPanelCenter.SuspendLayout();
            this.txPanelRight.SuspendLayout();
            this.txPanelLeft.SuspendLayout();
            this.txPanelTop.SuspendLayout();
            this.txPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // txPanelCenter
            // 
            this.txPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.txPanelCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelCenter.Controls.Add(this.txPanelRight);
            this.txPanelCenter.Controls.Add(this.txPanelLeft);
            this.txPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelCenter.Location = new System.Drawing.Point(0, 48);
            this.txPanelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelCenter.Name = "txPanelCenter";
            this.txPanelCenter.Size = new System.Drawing.Size(1378, 516);
            this.txPanelCenter.TabIndex = 6;
            // 
            // txPanelRight
            // 
            this.txPanelRight.AutoScroll = true;
            this.txPanelRight.BackColor = System.Drawing.Color.Transparent;
            this.txPanelRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelRight.Controls.Add(this.panelDetailProgress);
            this.txPanelRight.Controls.Add(this.panelMainProgress);
            this.txPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanelRight.Location = new System.Drawing.Point(277, 0);
            this.txPanelRight.Name = "txPanelRight";
            this.txPanelRight.Size = new System.Drawing.Size(1101, 516);
            this.txPanelRight.TabIndex = 8;
            // 
            // panelDetailProgress
            // 
            this.panelDetailProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetailProgress.Location = new System.Drawing.Point(144, 0);
            this.panelDetailProgress.Name = "panelDetailProgress";
            this.panelDetailProgress.Size = new System.Drawing.Size(957, 516);
            this.panelDetailProgress.TabIndex = 1;
            // 
            // panelMainProgress
            // 
            this.panelMainProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainProgress.Location = new System.Drawing.Point(0, 0);
            this.panelMainProgress.Name = "panelMainProgress";
            this.panelMainProgress.Size = new System.Drawing.Size(144, 516);
            this.panelMainProgress.TabIndex = 0;
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
            this.txPanelLeft.Size = new System.Drawing.Size(277, 516);
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
            this.tvEngineCode.Size = new System.Drawing.Size(277, 516);
            this.tvEngineCode.TabIndex = 0;
            this.tvEngineCode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEngineCode_AfterSelect);
            // 
            // txPanelBottom
            // 
            this.txPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.txPanelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanelBottom.Location = new System.Drawing.Point(0, 564);
            this.txPanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.txPanelBottom.Name = "txPanelBottom";
            this.txPanelBottom.Size = new System.Drawing.Size(1378, 51);
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
            this.txPanelTop.Size = new System.Drawing.Size(1378, 48);
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
            this.txPanel1.Size = new System.Drawing.Size(1378, 48);
            this.txPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "—";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
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
            this.txDateTimePicker2.Location = new System.Drawing.Point(313, 9);
            this.txDateTimePicker2.Name = "txDateTimePicker2";
            this.txDateTimePicker2.ShowCheckBox = true;
            this.txDateTimePicker2.Size = new System.Drawing.Size(140, 26);
            this.txDateTimePicker2.TabIndex = 1;
            this.txDateTimePicker2.Value = null;
            this.txDateTimePicker2.ValueChanged += new System.EventHandler(this.LoadTreeView);
            // 
            // txDateTimePicker1
            // 
            this.txDateTimePicker1.CalendarForeColor = System.Drawing.Color.Blue;
            this.txDateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txDateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))), ((int)(((byte)(237)))));
            this.txDateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.CadetBlue;
            this.txDateTimePicker1.Checked = false;
            this.txDateTimePicker1.Location = new System.Drawing.Point(137, 9);
            this.txDateTimePicker1.Name = "txDateTimePicker1";
            this.txDateTimePicker1.ShowCheckBox = true;
            this.txDateTimePicker1.Size = new System.Drawing.Size(140, 26);
            this.txDateTimePicker1.TabIndex = 1;
            this.txDateTimePicker1.Value = null;
            this.txDateTimePicker1.ValueChanged += new System.EventHandler(this.LoadTreeView);
            // 
            // ProgressForm
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
            this.Name = "ProgressForm";
            this.ResizeEnable = false;
            this.Text = "实时进度";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoadTreeView);
            this.txPanel3.ResumeLayout(false);
            this.txPanelCenter.ResumeLayout(false);
            this.txPanelRight.ResumeLayout(false);
            this.txPanelLeft.ResumeLayout(false);
            this.txPanelTop.ResumeLayout(false);
            this.txPanel1.ResumeLayout(false);
            this.txPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXPanel txPanel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelCenter;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelRight;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelLeft;
        private System.Windows.Forms.TreeView tvEngineCode;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelBottom;
        private TX.Framework.WindowUI.Controls.TXPanel txPanelTop;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TX.Framework.WindowUI.Controls.TXDateTimePicker txDateTimePicker2;
        private TX.Framework.WindowUI.Controls.TXDateTimePicker txDateTimePicker1;
        private System.Windows.Forms.Panel panelMainProgress;
        private System.Windows.Forms.Panel panelDetailProgress;
    }
}