namespace WindowsSpotlightWallpaper
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.下一张ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一张ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设为壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下一张ToolStripMenuItem,
            this.上一张ToolStripMenuItem,
            this.设为壁纸ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 下一张ToolStripMenuItem
            // 
            this.下一张ToolStripMenuItem.Name = "下一张ToolStripMenuItem";
            this.下一张ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.下一张ToolStripMenuItem.Text = "下一张";
            // 
            // 上一张ToolStripMenuItem
            // 
            this.上一张ToolStripMenuItem.Name = "上一张ToolStripMenuItem";
            this.上一张ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.上一张ToolStripMenuItem.Text = "上一张";
            // 
            // 设为壁纸ToolStripMenuItem
            // 
            this.设为壁纸ToolStripMenuItem.Name = "设为壁纸ToolStripMenuItem";
            this.设为壁纸ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设为壁纸ToolStripMenuItem.Text = "设为壁纸";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 540);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(966, 93);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(105, 28);
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.Text = "上一张";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(966, 193);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(105, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "下一张";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(966, 291);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(105, 28);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "设为壁纸";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 568);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "windows聚焦壁纸";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下一张ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一张ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设为壁纸ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button SetButton;
    }
}

