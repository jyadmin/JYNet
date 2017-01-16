namespace DMS.UI.Common
{
    partial class DetailForm
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
            this.tsTool = new System.Windows.Forms.ToolStrip();
            this.tbcCancel = new DMS.UI.Common.ToolBarCommand();
            this.SuspendLayout();
            // 
            // tsTool
            // 
            this.tsTool.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsTool.Location = new System.Drawing.Point(3, 27);
            this.tsTool.Name = "tsTool";
            this.tsTool.Size = new System.Drawing.Size(469, 25);
            this.tsTool.TabIndex = 0;
            this.tsTool.Text = "toolStrip1";
            // 
            // tbcCancel
            // 
            this.tbcCancel.CommandName = "取消";
            this.tbcCancel.ImagePath = null;
            this.tbcCancel.IsEnable = true;
            this.tbcCancel.IsVisible = true;
            this.tbcCancel.Name = "取消";
            this.tbcCancel.Type = DMS.UI.Common.CommandType.Cancel;
            this.tbcCancel.Commanded += new System.EventHandler(this.tbcCancel_Commanded);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 558);
            this.Controls.Add(this.tsTool);
            this.DockAreas = ((TX.Framework.WindowUI.Controls.Docking.DockAreas)((((((TX.Framework.WindowUI.Controls.Docking.DockAreas.Float | TX.Framework.WindowUI.Controls.Docking.DockAreas.DockLeft) 
            | TX.Framework.WindowUI.Controls.Docking.DockAreas.DockRight) 
            | TX.Framework.WindowUI.Controls.Docking.DockAreas.DockTop) 
            | TX.Framework.WindowUI.Controls.Docking.DockAreas.DockBottom) 
            | TX.Framework.WindowUI.Controls.Docking.DockAreas.Document)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "DetailForm";
            this.ShowHint = TX.Framework.WindowUI.Controls.Docking.DockState.Unknown;
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTool;
        protected ToolBarCommand tbcCancel;
    }
}