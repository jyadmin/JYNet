namespace DMS.UI.Common
{
    partial class ListForm
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
            this.dgMain = new DMS.Common.Controls.QMDataGrid();
            this.txPanel2 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txPager1 = new TX.Framework.WindowUI.Controls.TXPager();
            this.txPanel3 = new TX.Framework.WindowUI.Controls.TXPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.txPanel2.SuspendLayout();
            this.txPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMain
            // 
            this.dgMain.AlternatingBackColor = System.Drawing.Color.White;
            this.dgMain.BackColor = System.Drawing.Color.White;
            this.dgMain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgMain.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgMain.CaptionForeColor = System.Drawing.Color.Lavender;
            this.dgMain.CaptionVisible = false;
            this.dgMain.DataMember = "";
            this.dgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMain.ForeColor = System.Drawing.Color.Black;
            this.dgMain.GridLineColor = System.Drawing.Color.Wheat;
            this.dgMain.HeaderBackColor = System.Drawing.Color.CadetBlue;
            this.dgMain.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMain.HeaderForeColor = System.Drawing.Color.White;
            this.dgMain.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.dgMain.Location = new System.Drawing.Point(0, 0);
            this.dgMain.Name = "dgMain";
            this.dgMain.ParentRowsBackColor = System.Drawing.Color.Ivory;
            this.dgMain.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgMain.RowHeadersVisible = false;
            this.dgMain.SelectionBackColor = System.Drawing.Color.Wheat;
            this.dgMain.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dgMain.Size = new System.Drawing.Size(613, 365);
            this.dgMain.TabIndex = 0;
            // 
            // txPanel2
            // 
            this.txPanel2.BackColor = System.Drawing.Color.Transparent;
            this.txPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel2.Controls.Add(this.txPager1);
            this.txPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txPanel2.Location = new System.Drawing.Point(0, 365);
            this.txPanel2.Name = "txPanel2";
            this.txPanel2.Size = new System.Drawing.Size(613, 21);
            this.txPanel2.TabIndex = 2;
            // 
            // txPager1
            // 
            this.txPager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txPager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPager1.Location = new System.Drawing.Point(0, 0);
            this.txPager1.Name = "txPager1";
            this.txPager1.PageSize = 50;
            this.txPager1.Size = new System.Drawing.Size(613, 21);
            this.txPager1.TabIndex = 0;
            this.txPager1.Total = 0D;
            // 
            // txPanel3
            // 
            this.txPanel3.BackColor = System.Drawing.Color.Transparent;
            this.txPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel3.Controls.Add(this.dgMain);
            this.txPanel3.Controls.Add(this.txPanel2);
            this.txPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel3.Location = new System.Drawing.Point(2, 20);
            this.txPanel3.Name = "txPanel3";
            this.txPanel3.Size = new System.Drawing.Size(613, 386);
            this.txPanel3.TabIndex = 3;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 408);
            this.Controls.Add(this.txPanel3);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.txPanel2.ResumeLayout(false);
            this.txPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DMS.Common.Controls.QMDataGrid dgMain;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel2;
        private TX.Framework.WindowUI.Controls.TXPanel txPanel3;
        protected TX.Framework.WindowUI.Controls.TXPager txPager1;
    }
}