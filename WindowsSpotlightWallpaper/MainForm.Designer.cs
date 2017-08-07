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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ForwarddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.OpenButton = new System.Windows.Forms.Button();
            this.ChangeTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionToolStripMenuItem,
            this.SetToolStripMenuItem,
            this.HelpToolStripMenuItem});
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
            this.SetToolStripMenuItem1,
            this.OpenToolStripMenuItem});
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.OptionToolStripMenuItem.Text = "操作";
            // 
            // ForwardToolStripMenuItem1
            // 
            this.ForwardToolStripMenuItem1.Name = "ForwardToolStripMenuItem1";
            this.ForwardToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.ForwardToolStripMenuItem1.Text = "上一张";
            this.ForwardToolStripMenuItem1.Click += new System.EventHandler(this.ForwardToolStripMenuItem1_Click);
            // 
            // NextToolStripMenuItem
            // 
            this.NextToolStripMenuItem.Name = "NextToolStripMenuItem";
            this.NextToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.NextToolStripMenuItem.Text = "下一张";
            this.NextToolStripMenuItem.Click += new System.EventHandler(this.NextToolStripMenuItem_Click);
            // 
            // SetToolStripMenuItem1
            // 
            this.SetToolStripMenuItem1.Name = "SetToolStripMenuItem1";
            this.SetToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.SetToolStripMenuItem1.Text = "设为壁纸";
            this.SetToolStripMenuItem1.Click += new System.EventHandler(this.SetToolStripMenuItem1_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.OpenToolStripMenuItem.Text = "打开文件夹";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SetToolStripMenuItem
            // 
            this.SetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFolderToolStripMenuItem,
            this.StartMethodToolStripMenuItem,
            this.ResetToolStripMenuItem,
            this.AutoToolStripMenuItem1,
            this.ChangeTimeToolStripMenuItem});
            this.SetToolStripMenuItem.Name = "SetToolStripMenuItem";
            this.SetToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SetToolStripMenuItem.Text = "设置";
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
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ResetToolStripMenuItem.Text = "恢复默认设置";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // AutoToolStripMenuItem1
            // 
            this.AutoToolStripMenuItem1.Name = "AutoToolStripMenuItem1";
            this.AutoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.AutoToolStripMenuItem1.Text = "自动更换";
            this.AutoToolStripMenuItem1.Click += new System.EventHandler(this.AutoToolStripMenuItem1_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem1,
            this.InstructionToolStripMenuItem,
            this.UpdateToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // AboutToolStripMenuItem1
            // 
            this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.AboutToolStripMenuItem1.Text = "关于";
            this.AboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // InstructionToolStripMenuItem
            // 
            this.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem";
            this.InstructionToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.InstructionToolStripMenuItem.Text = "使用说明";
            this.InstructionToolStripMenuItem.Click += new System.EventHandler(this.InstructionToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.UpdateToolStripMenuItem.Text = "更新";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
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
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "windows聚焦";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ForwarddToolStripMenuItem,
            this.NextdToolStripMenuItem,
            this.AutodToolStripMenuItem,
            this.OpendToolStripMenuItem,
            this.ExitdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 114);
            // 
            // ForwarddToolStripMenuItem
            // 
            this.ForwarddToolStripMenuItem.Name = "ForwarddToolStripMenuItem";
            this.ForwarddToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ForwarddToolStripMenuItem.Text = "上一张";
            this.ForwarddToolStripMenuItem.Click += new System.EventHandler(this.ForwarddToolStripMenuItem_Click);
            // 
            // NextdToolStripMenuItem
            // 
            this.NextdToolStripMenuItem.Name = "NextdToolStripMenuItem";
            this.NextdToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.NextdToolStripMenuItem.Text = "下一张";
            this.NextdToolStripMenuItem.Click += new System.EventHandler(this.NextdToolStripMenuItem_Click);
            // 
            // AutodToolStripMenuItem
            // 
            this.AutodToolStripMenuItem.Name = "AutodToolStripMenuItem";
            this.AutodToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AutodToolStripMenuItem.Text = "自动更换";
            this.AutodToolStripMenuItem.Click += new System.EventHandler(this.AutodToolStripMenuItem_Click);
            // 
            // OpendToolStripMenuItem
            // 
            this.OpendToolStripMenuItem.Name = "OpendToolStripMenuItem";
            this.OpendToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.OpendToolStripMenuItem.Text = "打开";
            this.OpendToolStripMenuItem.Click += new System.EventHandler(this.OpendToolStripMenuItem_Click);
            // 
            // ExitdToolStripMenuItem
            // 
            this.ExitdToolStripMenuItem.Name = "ExitdToolStripMenuItem";
            this.ExitdToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ExitdToolStripMenuItem.Text = "退出";
            this.ExitdToolStripMenuItem.Click += new System.EventHandler(this.ExitdToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3600000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(966, 376);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(105, 28);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "打开文件夹";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ChangeTimeToolStripMenuItem
            // 
            this.ChangeTimeToolStripMenuItem.Name = "ChangeTimeToolStripMenuItem";
            this.ChangeTimeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChangeTimeToolStripMenuItem.Text = "自动更换时间";
            this.ChangeTimeToolStripMenuItem.Click += new System.EventHandler(this.ChangeTimeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 568);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "windows聚焦壁纸";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem SetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InstructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem AutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ForwarddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitdToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeTimeToolStripMenuItem;
    }
}

