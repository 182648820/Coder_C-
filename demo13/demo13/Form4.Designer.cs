namespace demo13
{
    partial class Form4
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
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.Last = new System.Windows.Forms.Button();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.Location = new System.Drawing.Point(84, 47);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(439, 273);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            this.picPicture.Click += new System.EventHandler(this.picPicture_Click);
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(95, 336);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(80, 32);
            this.Last.TabIndex = 1;
            this.Last.Text = "上一张";
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // PlayMusic
            // 
            this.PlayMusic.Location = new System.Drawing.Point(267, 336);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(80, 32);
            this.PlayMusic.TabIndex = 2;
            this.PlayMusic.Text = "播放音乐";
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.button2_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(434, 336);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(80, 32);
            this.Next.TabIndex = 3;
            this.Next.Text = "下一张";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 396);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.PlayMusic);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.picPicture);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button PlayMusic;
        private System.Windows.Forms.Button Next;
    }
}