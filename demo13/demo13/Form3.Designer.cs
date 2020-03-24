namespace demo13
{
    partial class Form3
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
            this.close = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Acount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Man = new System.Windows.Forms.RadioButton();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Sex = new System.Windows.Forms.GroupBox();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Teacher = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckTeacher = new System.Windows.Forms.CheckBox();
            this.ckStudent = new System.Windows.Forms.CheckBox();
            this.Sex.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("宋体", 11F);
            this.close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.Location = new System.Drawing.Point(248, 236);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(77, 32);
            this.close.TabIndex = 11;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 11F);
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(110, 236);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(77, 32);
            this.login.TabIndex = 10;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(164, 128);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(124, 21);
            this.Password.TabIndex = 7;
            // 
            // Acount
            // 
            this.Acount.Location = new System.Drawing.Point(164, 79);
            this.Acount.Multiline = true;
            this.Acount.Name = "Acount";
            this.Acount.Size = new System.Drawing.Size(124, 21);
            this.Acount.TabIndex = 9;
            this.Acount.TextChanged += new System.EventHandler(this.Acount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(117, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(117, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "账号：";
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(33, 37);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(35, 16);
            this.Man.TabIndex = 12;
            this.Man.TabStop = true;
            this.Man.Text = "男";
            this.Man.UseVisualStyleBackColor = true;
            this.Man.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Location = new System.Drawing.Point(114, 37);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(35, 16);
            this.Woman.TabIndex = 13;
            this.Woman.TabStop = true;
            this.Woman.Text = "女";
            this.Woman.UseVisualStyleBackColor = true;
            this.Woman.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.Woman);
            this.Sex.Controls.Add(this.Man);
            this.Sex.Location = new System.Drawing.Point(375, 79);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(200, 59);
            this.Sex.TabIndex = 14;
            this.Sex.TabStop = false;
            this.Sex.Text = "性别";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(357, 144);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(47, 16);
            this.Student.TabIndex = 16;
            this.Student.TabStop = true;
            this.Student.Text = "学生";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Location = new System.Drawing.Point(357, 165);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(47, 16);
            this.Teacher.TabIndex = 15;
            this.Teacher.TabStop = true;
            this.Teacher.Text = "老师";
            this.Teacher.UseVisualStyleBackColor = true;
            this.Teacher.CheckedChanged += new System.EventHandler(this.Teacher_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "已婚\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(107, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "未婚";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(375, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "婚姻状况";
            // 
            // ckTeacher
            // 
            this.ckTeacher.AutoSize = true;
            this.ckTeacher.Location = new System.Drawing.Point(164, 187);
            this.ckTeacher.Name = "ckTeacher";
            this.ckTeacher.Size = new System.Drawing.Size(48, 16);
            this.ckTeacher.TabIndex = 19;
            this.ckTeacher.Text = "老师";
            this.ckTeacher.UseVisualStyleBackColor = true;
            this.ckTeacher.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckStudent
            // 
            this.ckStudent.AutoSize = true;
            this.ckStudent.Location = new System.Drawing.Point(248, 187);
            this.ckStudent.Name = "ckStudent";
            this.ckStudent.Size = new System.Drawing.Size(48, 16);
            this.ckStudent.TabIndex = 20;
            this.ckStudent.Text = "学生";
            this.ckStudent.UseVisualStyleBackColor = true;
            this.ckStudent.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 397);
            this.Controls.Add(this.ckTeacher);
            this.Controls.Add(this.ckStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.close);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Acount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Acount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.GroupBox Sex;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton Teacher;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckTeacher;
        private System.Windows.Forms.CheckBox ckStudent;
    }
}