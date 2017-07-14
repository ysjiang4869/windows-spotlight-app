using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSpotlightWallpaper.service
{
    public class SettingService
    {
        private static string path = System.Windows.Forms.Application.StartupPath + "\\settings.ini";


        private IniHandler handler;

        private static string saveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        private string lastRefreshTime;
        
        

        public SettingService()
        {
            this.handler = new IniHandler();
            handler.init(path);
            if (!handler.ExistINIFile())
            {
                handler.CreateFile();
            }
        }

        public void setSavePath(string path)
        {
            handler.IniWriteValue("basic", "savepath", path);
        }

        public string getSavePath()
        {
            string ret = handler.IniReadValue("basic", "savepath");
            if (ret == "")
            {
                ret = saveFolder;
            }
            return ret;
        }

        public void setLastRefreshTime(DateTime time)
        {
            handler.IniWriteValue("basic", "refreshtime", time.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public DateTime getLastRefreshTime()
        {
            string ret = handler.IniReadValue("basic", "refreshtime");
            if (ret == "")
            {
               return DateTime.Parse("2000-01-01");
            }
            return DateTime.Parse(ret);
        }
        
        public void reset()
        {
            handler.reset();
        }
    }
}
