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
            this.lblRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMain
            // 
            this.dgMain.AlternatingBackColor = System.Drawing.Color.White;
            this.dgMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMain.BackColor = System.Drawing.Color.White;
            this.dgMain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgMain.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgMain.CaptionForeColor = System.Drawing.Color.Lavender;
            this.dgMain.CaptionVisible = false;
            this.dgMain.DataMember = "";
            this.dgMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMain.ForeColor = System.Drawing.Color.Black;
            this.dgMain.GridLineColor = System.Drawing.Color.Wheat;
            this.dgMain.HeaderBackColor = System.Drawing.Color.CadetBlue;
            this.dgMain.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMain.HeaderForeColor = System.Drawing.Color.White;
            this.dgMain.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.dgMain.Location = new System.Drawing.Point(4, 33);
            this.dgMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgMain.Name = "dgMain";
            this.dgMain.ParentRowsBackColor = System.Drawing.Color.Ivory;
            this.dgMain.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgMain.RowHeadersVisible = false;
            this.dgMain.SelectionBackColor = System.Drawing.Color.Wheat;
            this.dgMain.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dgMain.Size = new System.Drawing.Size(815, 507);
            this.dgMain.TabIndex = 0;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(368, 13);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(192, 16);
            this.lblRecord.TabIndex = 1;
            this.lblRecord.Text = "当前一共检索出   条记录";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 544);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.dgMain);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DMS.Common.Controls.QMDataGrid dgMain;
        private System.Windows.Forms.Label lblRecord;
    }
}