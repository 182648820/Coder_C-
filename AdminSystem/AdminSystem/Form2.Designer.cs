namespace AdminSystem
{
    partial class Form2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.TextBox();
            this.LableName = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.LableAge = new System.Windows.Forms.Label();
            this.readContent = new System.Windows.Forms.ListBox();
            this.btnID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(359, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(573, 60);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(58, 30);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(176, 167);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(201, 21);
            this.Name.TabIndex = 4;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(176, 225);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(201, 21);
            this.Age.TabIndex = 5;
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(176, 276);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(201, 21);
            this.Sex.TabIndex = 6;
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Font = new System.Drawing.Font("宋体", 11F);
            this.LableName.Location = new System.Drawing.Point(105, 167);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(52, 15);
            this.LableName.TabIndex = 7;
            this.LableName.Text = "姓名：";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("宋体", 11F);
            this.LabelSex.Location = new System.Drawing.Point(105, 276);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(37, 15);
            this.LabelSex.TabIndex = 8;
            this.LabelSex.Text = "性别";
            // 
            // LableAge
            // 
            this.LableAge.AutoSize = true;
            this.LableAge.Font = new System.Drawing.Font("宋体", 11F);
            this.LableAge.Location = new System.Drawing.Point(105, 225);
            this.LableAge.Name = "LableAge";
            this.LableAge.Size = new System.Drawing.Size(37, 15);
            this.LableAge.TabIndex = 9;
            this.LableAge.Text = "年龄";
            // 
            // readContent
            // 
            this.readContent.FormattingEnabled = true;
            this.readContent.ItemHeight = 12;
            this.readContent.Location = new System.Drawing.Point(405, 135);
            this.readContent.Name = "readContent";
            this.readContent.Size = new System.Drawing.Size(226, 124);
            this.readContent.TabIndex = 10;
            // 
            // btnID
            // 
            this.btnID.AutoSize = true;
            this.btnID.Font = new System.Drawing.Font("宋体", 11F);
            this.btnID.Location = new System.Drawing.Point(105, 126);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(52, 15);
            this.btnID.TabIndex = 11;
            this.btnID.Text = "编号：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 126);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 21);
            this.txtID.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 363);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.readContent);
            this.Controls.Add(this.LableAge);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.LableName);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
           
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.Label LableName;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label LableAge;
        private System.Windows.Forms.ListBox readContent;
        private System.Windows.Forms.Label btnID;
        private System.Windows.Forms.TextBox txtID;
    }
}