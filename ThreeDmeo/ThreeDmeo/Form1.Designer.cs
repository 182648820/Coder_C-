namespace ThreeDmeo
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.pName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.TextBox();
            this.LableName = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.LableAge = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(373, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(587, 59);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(58, 30);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(192, 144);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(201, 21);
            this.pName.TabIndex = 16;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(192, 202);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(201, 21);
            this.Age.TabIndex = 17;
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(192, 253);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(201, 21);
            this.Sex.TabIndex = 18;
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Font = new System.Drawing.Font("宋体", 11F);
            this.LableName.Location = new System.Drawing.Point(121, 144);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(52, 15);
            this.LableName.TabIndex = 19;
            this.LableName.Text = "姓名：";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("宋体", 11F);
            this.LabelSex.Location = new System.Drawing.Point(121, 253);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(37, 15);
            this.LabelSex.TabIndex = 20;
            this.LabelSex.Text = "性别";
            // 
            // LableAge
            // 
            this.LableAge.AutoSize = true;
            this.LableAge.Font = new System.Drawing.Font("宋体", 11F);
            this.LableAge.Location = new System.Drawing.Point(121, 202);
            this.LableAge.Name = "LableAge";
            this.LableAge.Size = new System.Drawing.Size(37, 15);
            this.LableAge.TabIndex = 21;
            this.LableAge.Text = "年龄";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 171);
            this.dataGridView1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LableAge);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.LableName);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.Label LableName;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label LableAge;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

