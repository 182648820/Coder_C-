namespace demo16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Pause = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayOrPause = new System.Windows.Forms.Button();
            this.listPath = new System.Windows.Forms.ListBox();
            this.Remove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFile = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.Pictrue = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PSound = new System.Windows.Forms.Button();
            this.DSound = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GetTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Remove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictrue)).BeginInit();
            this.SuspendLayout();
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(13, 27);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(67, 49);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(13, 82);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(67, 49);
            this.Play.TabIndex = 2;
            this.Play.Text = "播放";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(13, 146);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(67, 49);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(50, 3);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(387, 261);
            this.musicPlayer.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.Play);
            this.groupBox1.Controls.Add(this.Pause);
            this.groupBox1.Location = new System.Drawing.Point(452, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PlayOrPause
            // 
            this.PlayOrPause.Location = new System.Drawing.Point(151, 281);
            this.PlayOrPause.Name = "PlayOrPause";
            this.PlayOrPause.Size = new System.Drawing.Size(75, 23);
            this.PlayOrPause.TabIndex = 6;
            this.PlayOrPause.Text = "播放";
            this.PlayOrPause.UseVisualStyleBackColor = true;
            this.PlayOrPause.Click += new System.EventHandler(this.PlayOrPause_Click);
            // 
            // listPath
            // 
            this.listPath.ContextMenuStrip = this.Remove;
            this.listPath.FormattingEnabled = true;
            this.listPath.ItemHeight = 12;
            this.listPath.Location = new System.Drawing.Point(411, 293);
            this.listPath.Name = "listPath";
            this.listPath.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listPath.Size = new System.Drawing.Size(242, 112);
            this.listPath.TabIndex = 7;
            this.listPath.SelectedIndexChanged += new System.EventHandler(this.listPath_SelectedIndexChanged);
            this.listPath.DoubleClick += new System.EventHandler(this.listPath_DoubleClick);
            // 
            // Remove
            // 
            this.Remove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeletMenuItem});
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(101, 26);
            // 
            // DeletMenuItem
            // 
            this.DeletMenuItem.Name = "DeletMenuItem";
            this.DeletMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DeletMenuItem.Text = "删除";
            this.DeletMenuItem.Click += new System.EventHandler(this.DeletMenuItem_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(468, 251);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(133, 26);
            this.SelectFile.TabIndex = 8;
            this.SelectFile.Text = "选择文件";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(50, 281);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "上一曲";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(330, 281);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "下一曲";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Pictrue
            // 
            this.Pictrue.Cursor = System.Windows.Forms.Cursors.No;
            this.Pictrue.Image = global::demo16.Properties.Resources._1;
            this.Pictrue.Location = new System.Drawing.Point(266, 310);
            this.Pictrue.Name = "Pictrue";
            this.Pictrue.Size = new System.Drawing.Size(139, 137);
            this.Pictrue.TabIndex = 11;
            this.Pictrue.TabStop = false;
            this.Pictrue.Tag = "1";
            this.Pictrue.Click += new System.EventHandler(this.Pictrue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "停止";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PSound
            // 
            this.PSound.Font = new System.Drawing.Font("宋体", 11F);
            this.PSound.Location = new System.Drawing.Point(50, 324);
            this.PSound.Name = "PSound";
            this.PSound.Size = new System.Drawing.Size(75, 23);
            this.PSound.TabIndex = 13;
            this.PSound.Text = "+";
            this.PSound.UseVisualStyleBackColor = true;
            this.PSound.Click += new System.EventHandler(this.SoundSet_Click);
            // 
            // DSound
            // 
            this.DSound.Font = new System.Drawing.Font("宋体", 11F);
            this.DSound.Location = new System.Drawing.Point(50, 353);
            this.DSound.Name = "DSound";
            this.DSound.Size = new System.Drawing.Size(75, 23);
            this.DSound.TabIndex = 14;
            this.DSound.Text = "-";
            this.DSound.UseVisualStyleBackColor = true;
            this.DSound.Click += new System.EventHandler(this.DSound_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Time_Click);
            // 
            // GetTime
            // 
            this.GetTime.AutoSize = true;
            this.GetTime.Location = new System.Drawing.Point(172, 335);
            this.GetTime.Name = "GetTime";
            this.GetTime.Size = new System.Drawing.Size(0, 12);
            this.GetTime.TabIndex = 15;
            this.GetTime.Click += new System.EventHandler(this.Time_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.GetTime);
            this.Controls.Add(this.DSound);
            this.Controls.Add(this.PSound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pictrue);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.listPath);
            this.Controls.Add(this.PlayOrPause);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.musicPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Remove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pictrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlayOrPause;
        private System.Windows.Forms.ListBox listPath;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ContextMenuStrip Remove;
        private System.Windows.Forms.ToolStripMenuItem DeletMenuItem;
        private System.Windows.Forms.PictureBox Pictrue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PSound;
        private System.Windows.Forms.Button DSound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GetTime;
    }
}