using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using System.Data.SqlClient;

namespace DMS
{
    public partial class SystemSettingsForm : MainForm
    {
        public SqlConnection conn;
        public SystemSettingsForm(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = (TreeView)sender;
            //MessageBox.Show(treeView.SelectedNode.Name);
            switch(treeView.SelectedNode.Name){
                case "Dictionary" :
                    if (splitContainer1.Panel2.Controls.ContainsKey("DictionaryListForm"))
                    {
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(DictionaryListForm))
                            {
                                form.BringToFront();
                                //DictionaryListForm dictionaryListForm = (DictionaryListForm)form;
                                //dictionaryListForm.BringToFront();
                            }
                        }
                    }
                    else
                    {
                        DictionaryListForm dictionaryListForm = new DictionaryListForm(conn);
                        dictionaryListForm.TopLevel = false;
                        dictionaryListForm.FormBorderStyle = FormBorderStyle.None;
                        dictionaryListForm.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(dictionaryListForm);
                        dictionaryListForm.BringToFront();
                        dictionaryListForm.Show();
                    }
                    break;
                case "Employee":

                    if (splitContainer1.Panel2.Controls.ContainsKey("EmployeeListForm"))
                    {
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(EmployeeListForm))
                            {
                                form.BringToFront();
                                //EmployeeListForm employeeListForm = (EmployeeListForm)form;
                                //employeeListForm.BringToFront();
                            }
                        }
                    }else{
                        EmployeeListForm employeeListForm = new EmployeeListForm();
                        employeeListForm.TopLevel = false;
                        employeeListForm.FormBorderStyle = FormBorderStyle.None;
                        employeeListForm.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(employeeListForm);
                        employeeListForm.BringToFront();
                        employeeListForm.Show();
                    }
                    break;
            }
        }
    }
}
