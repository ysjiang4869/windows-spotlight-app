using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsSpotlightWallpaper.service;
using Microsoft.Win32;

namespace WindowsSpotlightWallpaper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            init();
            execute();
            view(index);
        }

        private string tempFolder;
        private  string horizontalFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Spotlight\\horizontal\\";
        private  string verticalFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Spotlight\\vertical\\";
        private  string originPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets\\";

        private static int index=0;
        private SettingService settingService = new SettingService();

        private List<FileInfo> files;

        private void execute()
        {
            bool res = copyFile();
            if (res)
            {
                classify();               
            }
            sortFiles(horizontalFolder);
        }
        private void init()
        {
            tempFolder = settingService.getSavePath() + "\\Spotlight\\CopyAssets\\";
            horizontalFolder = settingService.getSavePath() + "\\Spotlight\\horizontal\\";
            verticalFolder=settingService.getSavePath()+ "\\Spotlight\\vertical\\";
            Directory.CreateDirectory(tempFolder);
            Directory.CreateDirectory(horizontalFolder);
            Directory.CreateDirectory(verticalFolder);

            updateState();
        }
        /// <summary>
        /// copy the wallpaper file to 
        /// </summary>
        public bool copyFile()
        {
            DirectoryInfo dir1 = new DirectoryInfo(originPath);
            sortFiles(originPath);
            if (files[0].LastWriteTime < settingService.getLastRefreshTime())
            {
                return false;
            }
            foreach (FileInfo file in files)
            {
                if(file.Length<= 102400) { continue; }

                file.CopyTo(tempFolder + file.Name+".jpg",true);
                
            }
            settingService.setLastRefreshTime(DateTime.Now);
            return true;
        }

        public void classify()
        {
            DirectoryInfo dir1 = new DirectoryInfo(tempFolder);
            foreach (FileInfo file in dir1.GetFiles())
            {
                Image image = getImage(file.FullName);
               
                if (image.Width == 1920)
                {
                    file.CopyTo(horizontalFolder + file.Name,true);

                }

                if (image.Width == 1080)
                {
                    file.CopyTo(verticalFolder + file.Name,true);
                }
                file.Delete();
            }

        }

        public void sortFiles(string path)
        {
            DirectoryInfo dir1 = new DirectoryInfo(path);           
            files = dir1.GetFiles("*.*", SearchOption.TopDirectoryOnly).OrderByDescending(t => t.LastWriteTime).ToList();
            
        }

        private void view(int index)
        {
            string path = files[index].FullName;
            pictureBox.ImageLocation = path;
        }

        private Image getImage(string path)
        {
            FileStream fs = File.OpenRead(path); //OpenRead
            int filelength = 0;
            filelength = (int)fs.Length; //获得文件长度 
            Byte[] image = new Byte[filelength]; //建立一个字节数组 
            fs.Read(image, 0, filelength); //按字节流读取 
            Image result = Image.FromStream(fs);
            fs.Close();
            return result;
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            moveForward();
           
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            moveNext();
           
        }

        private void moveNext()
        {
            if (index < files.Count - 1)
            {
                view(++index);
            }
            else
            {

                DialogResult res = MessageBox.Show("已浏览完毕，是否从头开始？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res.Equals(DialogResult.OK))
                {
                    index = 0;
                    view(index);
                }
            }
        }

        private void moveForward()
        {
            if (index > 0)
            {
                view(--index);
            }
            else
            {
                DialogResult res = MessageBox.Show("已经是第一幅图像啦！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            Wallpaper.Set(files[index].FullName, Wallpaper.Style.Centered);
        }

        private void ForwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            moveForward();
        }

        private void NextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveNext();
        }

        private void SetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Wallpaper.Set(files[index].FullName, Wallpaper.Style.Centered);
        }

        private void SaveFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult res = browser.ShowDialog();
            if (res.Equals(DialogResult.OK))
            {
                string oldfolder= settingService.getSavePath() + "\\Spotlight\\";
                settingService.setSavePath(browser.SelectedPath);
                init();
                Directory.Move(oldfolder, settingService.getSavePath() + "\\Spotlight\\");
            }
        }
        //TODO add auto start
        private void StartMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.StartMethodToolStripMenuItem.Text == "开机启动")
            {
                AutoRun(true);
                updateState();
                
            }
            else
            {
                AutoRun(false);
                updateState();
               
            }
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingService.reset();
            this.timer1.Enabled = false;
            AutoRun(false);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = true;
                this.Hide();
                this.ShowInTaskbar = false;            
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
                this.Show();
                this.Activate();
                this.WindowState = FormWindowState.Normal;
            }
           
        }

        private void ForwarddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveForward();
        }

        private void NextdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveNext();
        }

        private void AutodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.AutoToolStripMenuItem1.Text == "自动更换")
            {                
                settingService.setAutoChange("true");
                updateState();
            }
            else
            {             
                settingService.setAutoChange("false");
                updateState();
            }    
        }

        private void OpendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void InstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ysjiang4869/windows-spotlight-app");
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请到 http://jiangyuesong.me 下载最新程序文件！", "提示", MessageBoxButtons.OK);
        }

        private void AutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.AutoToolStripMenuItem1.Text == "自动更换")
            {                              
                settingService.setAutoChange("true");
                updateState();
            }
            else
            {                           
                settingService.setAutoChange("false");
                updateState();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < files.Count - 1)
            {
                view(++index);
            }
            else
            {
                index = 0;
                view(index);
            }
            Wallpaper.Set(files[index].FullName, Wallpaper.Style.Centered);           
        }

        private void AutoRun(bool IsAutoRun)
        {
            //获取程序执行路径..
            string starupPath = Application.ExecutablePath;
            //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.
            RegistryKey loca = Registry.LocalMachine;
            RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            try
            {
                //SetValue:存储值的名称
                if (IsAutoRun == false) run.SetValue("WindowsSpotlight", false);//取消开机运行
                else run.SetValue("WindowsSpotlight", starupPath);//设置开机运行
                loca.Close();                
            }
            catch
            {
                MessageBox.Show("请以管理员身运行程序！", "警告", MessageBoxButtons.OK);
            }
            updateState();
        }

        //更改自动更换和开机启动菜单的值
        private void updateState()
        {
            if (settingService.getAutoRun() == "true")
            {
                this.StartMethodToolStripMenuItem.Text = "取消开机启动";
            }
            else
            {
                this.StartMethodToolStripMenuItem.Text = "开机启动";
            }

            if (settingService.getAutoChange() == "true")
            {
                this.timer1.Enabled = true;
                this.AutoToolStripMenuItem1.Text = "取消自动更换";
                this.AutodToolStripMenuItem.Text = "取消自动更换";
            }
            else
            {
                this.timer1.Enabled = false;
                this.AutoToolStripMenuItem1.Text = "自动更换";
                this.AutodToolStripMenuItem.Text = "自动更换";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            execute();
        }
    }
}
