namespace demo13
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.bName = new System.Windows.Forms.Button();
            this.bPwd = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnWrap = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 61);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 21);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(87, 110);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(124, 21);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // bName
            // 
            this.bName.Font = new System.Drawing.Font("宋体", 11F);
            this.bName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bName.Location = new System.Drawing.Point(43, 183);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(77, 32);
            this.bName.TabIndex = 4;
            this.bName.Text = "登录";
            this.bName.UseVisualStyleBackColor = true;
            this.bName.Click += new System.EventHandler(this.button1_Click);
            // 
            // bPwd
            // 
            this.bPwd.Font = new System.Drawing.Font("宋体", 11F);
            this.bPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bPwd.Location = new System.Drawing.Point(167, 183);
            this.bPwd.Name = "bPwd";
            this.bPwd.Size = new System.Drawing.Size(77, 32);
            this.bPwd.TabIndex = 5;
            this.bPwd.Text = "关闭";
            this.bPwd.UseVisualStyleBackColor = true;
            this.bPwd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 50);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(430, 283);
            this.textBox.TabIndex = 6;
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // btnWrap
            // 
            this.btnWrap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWrap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWrap.Location = new System.Drawing.Point(55, 12);
            this.btnWrap.Name = "btnWrap";
            this.btnWrap.Size = new System.Drawing.Size(75, 23);
            this.btnWrap.TabIndex = 7;
            this.btnWrap.Text = "自动换行";
            this.btnWrap.UseVisualStyleBackColor = false;
            this.btnWrap.Click += new System.EventHandler(this.btnWrap_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(325, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 407);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWrap);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bPwd);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "ZYX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button bName;
        private System.Windows.Forms.Button bPwd;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnWrap;
        private System.Windows.Forms.Button btnSave;
    }
}

