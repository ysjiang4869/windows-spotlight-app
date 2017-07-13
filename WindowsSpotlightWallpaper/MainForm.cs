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

namespace WindowsSpotlightWallpaper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            init();
            copyFile();
            classify();
            sortFiles(horizontalFolder);
            view(index);
        }

        private static string tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Spotlight\\CopyAssets\\";
        private static string horizontalFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Spotlight\\horizontal\\";
        private static string verticalFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Spotlight\\vertical\\";
        private static string originPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets\\";

        private static int index=0;

        private List<FileInfo> files;

        private void init()
        {
            Directory.CreateDirectory(tempFolder);
            Directory.CreateDirectory(horizontalFolder);
            Directory.CreateDirectory(verticalFolder);
        }
        /// <summary>
        /// copy the wallpaper file to 
        /// </summary>
        public void copyFile()
        {
            DirectoryInfo dir1 = new DirectoryInfo(originPath);
            sortFiles(originPath);
            foreach (FileInfo file in files)
            {
                if(file.Length<= 102400) { continue; }

                file.CopyTo(tempFolder + file.Name + ".jpg",true);
                
            }
            
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
            files = dir1.GetFiles("*.*", SearchOption.TopDirectoryOnly).OrderBy(t => t.LastWriteTime).ToList();
            
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
            if (index > 0)
            {
                view(--index);
            }
            else
            {
                DialogResult res = MessageBox.Show("已经是第一幅图像啦！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void NextButton_Click(object sender, EventArgs e)
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

        private void SetButton_Click(object sender, EventArgs e)
        {
            Wallpaper.Set(files[index].FullName, Wallpaper.Style.Centered);
        }
    }
}
