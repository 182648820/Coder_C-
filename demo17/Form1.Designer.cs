namespace demo17
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.getContent = new System.Windows.Forms.Button();
            this.listNodes = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "写入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "点击";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // getContent
            // 
            this.getContent.Location = new System.Drawing.Point(553, 73);
            this.getContent.Name = "getContent";
            this.getContent.Size = new System.Drawing.Size(52, 61);
            this.getContent.TabIndex = 3;
            this.getContent.Text = "获取";
            this.getContent.UseVisualStyleBackColor = true;
            this.getContent.Click += new System.EventHandler(this.getContent_Click);
            // 
            // listNodes
            // 
            this.listNodes.Location = new System.Drawing.Point(332, 73);
            this.listNodes.Multiline = true;
            this.listNodes.Name = "listNodes";
            this.listNodes.Size = new System.Drawing.Size(202, 189);
            this.listNodes.TabIndex = 4;
            this.listNodes.WordWrap = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(553, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 61);
            this.button4.TabIndex = 5;
            this.button4.Text = "获取";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(553, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 61);
            this.button5.TabIndex = 6;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 392);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listNodes);
            this.Controls.Add(this.getContent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button getContent;
        private System.Windows.Forms.TextBox listNodes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}