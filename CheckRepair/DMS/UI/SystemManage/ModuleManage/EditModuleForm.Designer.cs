namespace DMS.UI.SystemManage.ModuleManage
{
    partial class EditModuleForm
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
            this.tbcUpdate = new DMS.UI.Common.ToolBarCommand();
            this.SuspendLayout();
            // 
            // tbcUpdate
            // 
            this.tbcUpdate.CommandName = "更新";
            this.tbcUpdate.ImagePath = null;
            this.tbcUpdate.IsEnable = true;
            this.tbcUpdate.IsVisible = true;
            this.tbcUpdate.Name = "更新";
            this.tbcUpdate.Type = DMS.UI.Common.CommandType.Update;
            this.tbcUpdate.Commanded += new System.EventHandler(this.tbcUpdate_Commanded);
            // 
            // EditModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(371, 427);
            this.Name = "EditModuleForm";
            this.Load += new System.EventHandler(this.EditModuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMS.UI.Common.ToolBarCommand tbcUpdate;
    }
}
