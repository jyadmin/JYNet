/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 8:51:05 PM
 * */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DMS.Common.Validate
{
    internal class CustomValidater : UIValidater
    {
        ExecuteValidate m_validateExecuter;

        public CustomValidater(ExecuteValidate validateExecuter)
        {
            m_validateExecuter = validateExecuter;
        }

        public override bool Validate(out string errorMessage, out System.Windows.Forms.Control[] errorControls)
        {
            ValidatingResult result = null;

            if (m_validateExecuter.Method.IsStatic)
            {
                result = m_validateExecuter.Invoke();
            }
            else
            {
                result = (ValidatingResult)m_validateExecuter.Method.Invoke(m_validateExecuter.Target, null);
            }
            if (!result.Success)
            {
                errorMessage = result.ErrorMessage;
                errorControls = result.ErrorControls;
            }
            else
            {
                errorMessage = null;
                errorControls = null;
            }
            return result.Success;
        }
    }

    public delegate ValidatingResult ExecuteValidate();

    public class ValidatingResult
    {
        public bool Success;
        public string ErrorMessage;
        public Control[] ErrorControls;
    }
}
