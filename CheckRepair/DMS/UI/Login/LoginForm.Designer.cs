namespace Login
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txTextBox1 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBox2 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(167, 206);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 0;
            this.txButton1.Text = "登录";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(311, 206);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(100, 28);
            this.txButton2.TabIndex = 1;
            this.txButton2.Text = "取消";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.txButton2_Click);
            // 
            // txTextBox1
            // 
            this.txTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox1.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox1.Image = null;
            this.txTextBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox1.Location = new System.Drawing.Point(242, 111);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTextBox1.PasswordChar = '\0';
            this.txTextBox1.Required = false;
            this.txTextBox1.Size = new System.Drawing.Size(169, 22);
            this.txTextBox1.TabIndex = 2;
            this.txTextBox1.Text = "admin";
            // 
            // txTextBox2
            // 
            this.txTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox2.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox2.Image = null;
            this.txTextBox2.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox2.Location = new System.Drawing.Point(242, 157);
            this.txTextBox2.Name = "txTextBox2";
            this.txTextBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTextBox2.PasswordChar = '*';
            this.txTextBox2.Required = false;
            this.txTextBox2.Size = new System.Drawing.Size(169, 22);
            this.txTextBox2.TabIndex = 3;
            this.txTextBox2.Text = "111111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(164, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(164, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "密  码：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(620, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTextBox2);
            this.Controls.Add(this.txTextBox1);
            this.Controls.Add(this.txButton2);
            this.Controls.Add(this.txButton1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(500, 200);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResizeEnable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTextBox2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox1;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

