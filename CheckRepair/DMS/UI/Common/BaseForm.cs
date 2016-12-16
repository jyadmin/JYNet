/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:16:00 PM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.Common;
using DMS.Common.Validate;

namespace DMS.UI.Common
{
    public partial class BaseForm : Form
    {
        protected bool operationIsSuccessful = false;
        protected Validater validater;

        public BaseForm()
        {
            InitializeComponent();
            validater = new Validater();
            //validater.ErrorColor = ColorConfiguration.GetColor("ErrorInputElementBackColor");
            //validater.RequiredColor =ColorConfiguration.GetColor("RequiredInputElementBackColor");
            this.FormClosing += new FormClosingEventHandler(BaseForm_FormClosing);
        }

        void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (operationIsSuccessful)
                this.DialogResult = DialogResult.OK;
        }

        #region methods about adding validate items

        public void AddRequiredTextItem(Control control, string requiredErrorMessage)
        {
            validater.AddRequiredTextItem(control, requiredErrorMessage);
        }

        public void AddRequiredTextItem(Control control, string requiredErrorMessage, string regex, string regexErrorMessage)
        {
            validater.AddRequiredTextItem(control, requiredErrorMessage, regex, regexErrorMessage);
        }

        public void AddUnRequriedTextItem(Control control, string regex, string regexErrorMessage)
        {
            validater.AddUnRequiredTextItem(control, regex, regexErrorMessage);
        }

        public void AddCustomValidator(ExecuteValidate validateExecuter)
        {
            validater.AddCustomValidater(validateExecuter);
        }

        public new bool Validate()
        {
            string errorMessage;
            if (!validater.Validate(out errorMessage))
            {
                MsgHelper.ShowInformationMsgBox(errorMessage);
                return false;
            }
            return true;
        }

        #endregion

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            this.Text = title;
        }

        public void FinishClose()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void CancelClose()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void SetSuccess(bool success)
        {
            this.operationIsSuccessful = success;
        }
    }
}
