namespace demo14
{
    partial class Form5
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
            this.btnST = new System.Windows.Forms.Button();
            this.btnJD = new System.Windows.Forms.Button();
            this.btnBu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.computer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.judge = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnST
            // 
            this.btnST.Location = new System.Drawing.Point(226, 334);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(75, 23);
            this.btnST.TabIndex = 0;
            this.btnST.Text = "石头";
            this.btnST.UseVisualStyleBackColor = true;
            this.btnST.Click += new System.EventHandler(this.btnST_Click);
            // 
            // btnJD
            // 
            this.btnJD.Location = new System.Drawing.Point(432, 334);
            this.btnJD.Name = "btnJD";
            this.btnJD.Size = new System.Drawing.Size(75, 23);
            this.btnJD.TabIndex = 1;
            this.btnJD.Text = "剪刀";
            this.btnJD.UseVisualStyleBackColor = true;
            this.btnJD.Click += new System.EventHandler(this.btnJD_Click);
            // 
            // btnBu
            // 
            this.btnBu.Location = new System.Drawing.Point(654, 334);
            this.btnBu.Name = "btnBu";
            this.btnBu.Size = new System.Drawing.Size(75, 23);
            this.btnBu.TabIndex = 2;
            this.btnBu.Text = "布";
            this.btnBu.UseVisualStyleBackColor = true;
            this.btnBu.Click += new System.EventHandler(this.btnBu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(283, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "电脑：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(445, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "裁判：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(651, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "玩家：";
            // 
            // computer
            // 
            this.computer.AutoSize = true;
            this.computer.Font = new System.Drawing.Font("宋体", 11F);
            this.computer.Location = new System.Drawing.Point(335, 100);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(0, 15);
            this.computer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // judge
            // 
            this.judge.AutoSize = true;
            this.judge.Font = new System.Drawing.Font("宋体", 11F);
            this.judge.Location = new System.Drawing.Point(503, 225);
            this.judge.Name = "judge";
            this.judge.Size = new System.Drawing.Size(0, 15);
            this.judge.TabIndex = 8;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("宋体", 11F);
            this.player.Location = new System.Drawing.Point(709, 100);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(0, 15);
            this.player.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 463);
            this.Controls.Add(this.player);
            this.Controls.Add(this.judge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBu);
            this.Controls.Add(this.btnJD);
            this.Controls.Add(this.btnST);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnST;
        private System.Windows.Forms.Button btnJD;
        private System.Windows.Forms.Button btnBu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label computer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label judge;
        private System.Windows.Forms.Label player;
    }
}