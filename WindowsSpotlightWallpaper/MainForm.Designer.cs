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
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OptionToolStripMenuItem
            // 
            this.OptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ForwardToolStripMenuItem1,
            this.NextToolStripMenuItem,
            this.SetToolStripMenuItem1});
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.OptionToolStripMenuItem.Text = "操作";
            // 
            // ForwardToolStripMenuItem1
            // 
            this.ForwardToolStripMenuItem1.Name = "ForwardToolStripMenuItem1";
            this.ForwardToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.ForwardToolStripMenuItem1.Text = "上一张";
            this.ForwardToolStripMenuItem1.Click += new System.EventHandler(this.ForwardToolStripMenuItem1_Click);
            // 
            // NextToolStripMenuItem
            // 
            this.NextToolStripMenuItem.Name = "NextToolStripMenuItem";
            this.NextToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.NextToolStripMenuItem.Text = "下一张";
            this.NextToolStripMenuItem.Click += new System.EventHandler(this.NextToolStripMenuItem_Click);
            // 
            // SetToolStripMenuItem1
            // 
            this.SetToolStripMenuItem1.Name = "SetToolStripMenuItem1";
            this.SetToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.SetToolStripMenuItem1.Text = "设为壁纸";
            this.SetToolStripMenuItem1.Click += new System.EventHandler(this.SetToolStripMenuItem1_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFolderToolStripMenuItem,
            this.StartMethodToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // SaveFolderToolStripMenuItem
            // 
            this.SaveFolderToolStripMenuItem.Name = "SaveFolderToolStripMenuItem";
            this.SaveFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveFolderToolStripMenuItem.Text = "修改存储路径";
            this.SaveFolderToolStripMenuItem.Click += new System.EventHandler(this.SaveFolderToolStripMenuItem_Click);
            // 
            // StartMethodToolStripMenuItem
            // 
            this.StartMethodToolStripMenuItem.Name = "StartMethodToolStripMenuItem";
            this.StartMethodToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StartMethodToolStripMenuItem.Text = "开机启动";
            this.StartMethodToolStripMenuItem.Click += new System.EventHandler(this.StartMethodToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1,
            this.说明ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.说明ToolStripMenuItem.Text = "说明";
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
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ResetToolStripMenuItem.Text = "恢复默认设置";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.ToolStripMenuItem ForwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
    }
}

