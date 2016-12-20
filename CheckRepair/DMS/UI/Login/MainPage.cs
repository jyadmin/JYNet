﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using DMS;
using System.Threading;
using System.Data.SqlClient;
using DMS.DomainObjects;
using DMS.DomainObjects.BasicInfo;
using DMS.Common;
using DMS.UI.Common;

namespace MainPage
{
    public partial class MainPage : MainForm
    {
        private string userName = "";
        private int[] location = {10,10};
        public List<object> MenuObjects = new List<object>();
        public List<Module> Modules = new List<Module>();
        public List<Button> Buttons = new List<Button>();
        //public Dictionary<string, >

        public MainPage(string userName, SqlConnection conn)
        {
            InitializeComponent();
            this.userName = userName;
            label1.Text = "欢迎你，" + CurrentUser.Instance.User.LoginName;
            load_Menu();
        }

        //从数据库中读取等级为1的菜单，加载到主页面上
        private void load_Menu(){
            //设置FlowLayoutPanel大小
            flowLayoutPanel1.Width = 490;
            flowLayoutPanel1.Width = 500;
            //清空FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();
            //获取主页菜单
            foreach (Module module in CurrentUser.Instance.Role.Modules)
            {
                if (module.Level == 1)
                {
                    Modules.Add(module);
                    
                }
            }
            //
            for (int i = 0; i < Modules.Count; i++)
            {
                //object runner = Reflector.Reflect(module.TypeFullName);
                //MenuObjects.Add(runner);
                Button bt = new Button();
                switch (Modules[i].Name)
                {
                    case "系统设置":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(53)))), ((int)(((byte)(42)))));
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "工长派工":
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(134)))), ((int)(((byte)(240)))));
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = "工长派工";
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "互检":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(209)))), ((int)(((byte)(219)))));
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "实时进度":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "数据查询统计":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(82)))));
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "班组风采":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.Red;
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "文电传达":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "事务公开":
                        //设置颜色
                        bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(85)))), ((int)(((byte)(47)))));
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                    case "8S管理":
                        //设置颜色
                        bt.BackColor = System.Drawing.SystemColors.HotTrack;
                        //设置Dock
                        bt.Dock = System.Windows.Forms.DockStyle.Top;
                        bt.FlatAppearance.BorderSize = 0;
                        bt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.ForeColor = System.Drawing.Color.White;
                        //设置大小和位置
                        setLocation(bt, Modules[i].Size);
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Name = Modules[i].ID.ToString();
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.TabIndex = 0;
                        bt.Text = Modules[i].Name;
                        bt.UseVisualStyleBackColor = false;
                        //bt.Click += new System.EventHandler(this.button_Click);
                        flowLayoutPanel1.Controls.Add(bt);
                        break;
                }

            }

        }

        public void setLocation(Button bt, int moduleSize){
            if (moduleSize == 2)
            {

                if (location[0] + 230 > 489)
                {
                    location[0] = 10;
                    location[1] = location[1] + 110 + 10;//换行
                }
                bt.Location = new System.Drawing.Point(location[0], location[1]);//
                bt.Size = new System.Drawing.Size(230, 110);
                location[0] = location[0] + 230 + 10;
            }
            else
            {
                if (location[0] + 120 > 489)
                {
                    location[0] = 10;
                    location[1] = location[1] + 110 + 10;//换行
                }
                bt.Location = new System.Drawing.Point(location[0], location[1]);//
                bt.Size = new System.Drawing.Size(110, 110);
                location[0] = location[0] + 120 + 10;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //判断按钮编号
            Button btn = (Button)sender;
            object runner = null;
            foreach (Module module in Modules)
            {
                if (module.ID.ToString() == btn.Name)
                {
                    runner = Reflector.Reflect(module.TypeFullName);
                    if (runner != null)
                    {
                        IModule r = (IModule)runner;
                        r.Run();
                    }
                }
            }
            /*
            switch (btn.Name)
            {
                case "SystemSettings":
                    //Thread th = new Thread(fun => { Application.Run(new DMS.UI.SystemSetForm()); });
                    //th.Start();
                    foreach (Module module in Modules)
                    {
                        if (module.Name == "系统设置")
                        {
                            object runner = Reflector.Reflect(module.TypeFullName);
                            
                        }
                    }

                    //DMS.UI.SystemSetForm.Current.ShowDialog();
                    break;
                case "AssignTask":
                    foreach (Module module in Modules)
                    {
                        if (module.Name == "工长派工")
                        {
                            object runner = Reflector.Reflect(module.TypeFullName);
                            if (runner != null)
                            {
                                IModule r = (IModule)runner;
                                r.Run();
                            }
                        }
                    }
                    break;
            }*/
        }
    }
}
