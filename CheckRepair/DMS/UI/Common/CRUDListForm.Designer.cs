namespace DMS.UI.Common
{
    partial class CRUDListForm
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
            this.tbcAdd = new DMS.UI.Common.ToolBarCommand();
            this.tbcModify = new DMS.UI.Common.ToolBarCommand();
            this.tbcView = new DMS.UI.Common.ToolBarCommand();
            this.tbcDelete = new DMS.UI.Common.ToolBarCommand();

            // 
            // tbcAdd
            // 
            this.tbcAdd.CommandName = "添加";
            this.tbcAdd.ImagePath = null;
            this.tbcAdd.IsEnable = true;
            this.tbcAdd.IsVisible = true;
            this.tbcAdd.Name = "添加";
            this.tbcAdd.Type = DMS.UI.Common.CommandType.New;
            this.tbcAdd.Commanded += new System.EventHandler(this.tbcAdd_Commanded);
            // 
            // tbcModify
            // 
            this.tbcModify.CommandName = "修改";
            this.tbcModify.ImagePath = null;
            this.tbcModify.IsEnable = true;
            this.tbcModify.IsVisible = true;
            this.tbcModify.Name = "修改";
            this.tbcModify.Type = DMS.UI.Common.CommandType.Modify;
            this.tbcModify.Commanded += new System.EventHandler(this.tbcModify_Commanded);
            // 
            // tbcView
            // 
            this.tbcView.CommandName = "查看";
            this.tbcView.ImagePath = null;
            this.tbcView.IsEnable = true;
            this.tbcView.IsVisible = true;
            this.tbcView.Name = "查看";
            this.tbcView.Type = DMS.UI.Common.CommandType.View;
            this.tbcView.Commanded += new System.EventHandler(this.tbcView_Commanded);
            // 
            // tbcDelete
            // 
            this.tbcDelete.CommandName = "删除";
            this.tbcDelete.ImagePath = null;
            this.tbcDelete.IsEnable = true;
            this.tbcDelete.IsVisible = true;
            this.tbcDelete.Name = "删除";
            this.tbcDelete.Type = DMS.UI.Common.CommandType.Delete;
            this.tbcDelete.Commanded += new System.EventHandler(this.tbcDelete_Commanded);

            this.Load += new System.EventHandler(CRUDList_Load);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "CRUDList";
        }
        #endregion

        protected DMS.UI.Common.ToolBarCommand tbcAdd;
        protected DMS.UI.Common.ToolBarCommand tbcModify;
        protected DMS.UI.Common.ToolBarCommand tbcView;
        protected DMS.UI.Common.ToolBarCommand tbcDelete;
    }
}