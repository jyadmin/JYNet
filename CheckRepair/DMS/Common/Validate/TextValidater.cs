/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 8:47:26 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DMS.Common.Validate
{
    internal class TextValidater : UIValidater
    {
        bool m_isRequired;
        string m_regularExpression;
        Control m_control;
        string m_requiredErrorMessage;
        string m_regexErrorMessage;

        public TextValidater(bool isRequired, string regularExpression, Control control, string requiredErrorMessage, string regexErrorMessage)
        {
            m_isRequired = isRequired;
            m_regularExpression = regularExpression;
            m_control = control;
            m_requiredErrorMessage = requiredErrorMessage;
            m_regexErrorMessage = regexErrorMessage;
        }

        public bool IsRequired
        {
            get { return m_isRequired; }
            set { m_isRequired = value; }
        }

        public string RegularExpression
        {
            get { return m_regularExpression; }
            set { m_regularExpression = value; }
        }

        public Control Control
        {
            get { return m_control; }
            set { m_control = value; }
        }

        public override bool Validate(out string errorMessage, out Control[] errorControls)
        {
            errorMessage = null;
            errorControls = null;
            if (m_control.Text == string.Empty)
            {
                if (m_isRequired)
                {
                    errorMessage = m_requiredErrorMessage;
                    errorControls = new Control[] { this.m_control };
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (m_regularExpression != null)
            {
                Regex regex = new Regex(m_regularExpression);
                if (!regex.IsMatch(m_control.Text))
                {
                    errorMessage = m_regexErrorMessage;
                    errorControls = new Control[] { this.m_control };
                    return false;
                }
            }
            return true;
        }
    }
}
