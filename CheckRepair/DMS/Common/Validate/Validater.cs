/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 8:45:46 PM
 * */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace DMS.Common.Validate
{
    public class Validater
    {
        ArrayList m_validaters;
        ErrorManager m_errorManager;

        //the defualt color used on requried control is lightblue
        Color m_requiredColor = Color.LightBlue;

        public Validater()
        {
            m_validaters = new ArrayList();
            m_errorManager = new ErrorManager();
        }

        public Color ErrorColor
        {
            get { return m_errorManager.ErrorColor; }
            set { m_errorManager.ErrorColor = value; }
        }

        public Color RequiredColor
        {
            get { return m_requiredColor; }
            set { m_requiredColor = value; }
        }

        public void AddRequiredTextItem(Control control, string requiredErrorMessage)
        {
            m_validaters.Add(new TextValidater(true, null, control, requiredErrorMessage, null));
            control.BackColor = m_requiredColor;
        }

        public void AddRequiredTextItem(Control control, string requiredErrorMessage, string regex, string regxErrorMessage)
        {
            m_validaters.Add(new TextValidater(true, regex, control, requiredErrorMessage, regxErrorMessage));
            control.BackColor = m_requiredColor;
        }

        public void AddUnRequiredTextItem(Control control, string regex, string regxErrorMessage)
        {
            m_validaters.Add(new TextValidater(false, regex, control, null, regxErrorMessage));
        }

        public void AddCustomValidater(ExecuteValidate validateExecuter)
        {
            m_validaters.Add(new CustomValidater(validateExecuter));
        }

        public bool Validate(out string errorMessage)
        {
            errorMessage = null;
            Control[] errorControls = null;
            foreach (UIValidater validater in m_validaters)
            {
                if (!validater.Validate(out errorMessage, out errorControls))
                {
                    m_errorManager.SetErrors(errorControls);
                    errorControls[0].Focus();
                    return false;
                }
            }
            m_errorManager.ClearError();
            return true;
        }

        public void ClearError()
        {
            m_errorManager.ClearError();
        }
    }
}

