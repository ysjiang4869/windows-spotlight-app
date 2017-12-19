using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSpotlightWallpaper.service
{
    public class SettingService
    {       
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\spolightwallpaper\\settings.ini";
        private static string settingAppPath = Application.StartupPath + "\\SettingApp.exe";

        private IniHandler handler;

        private static string saveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); 
        
        

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


        public string getAutoRun()
        {
            string ret = handler.IniReadValue("basic", "autorun");
            if (ret == "")
            {
                string[] args = new string[] { "2" };
                runSettingApp(args);
                ret = handler.IniReadValue("basic", "autorun");
            }
            return ret;
                       
        }

        public void setAutoRun(bool IsAutoRun)
        {                      
            string[] args = new string[] { "1", Convert.ToString(IsAutoRun)};
            runSettingApp(args);
            handler.IniWriteValue("basic", "autorun", Convert.ToString(IsAutoRun).ToLower());           
        }

        public void runSettingApp(string[] args)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = settingAppPath;
            psi.Arguments = String.Join("  ", args);
            psi.Verb = "runas";

            var process = new Process();
            process.StartInfo = psi;
            process.Start();
            process.WaitForExit();           
        }
             

        public void setAutoChange(string set)
        {
            handler.IniWriteValue("basic", "autochange", set);
        }

        public string getAutoChange()
        {
            string ret = handler.IniReadValue("basic", "autochange");
            if (ret == "")
            {
                ret = "false";
            }
            return ret;
        }

        public void setChangeTime(int time)
        {
            handler.IniWriteValue("basic", "changetime", time.ToString());
        }

        public int getChangeTime()
        {
            string ret = handler.IniReadValue("basic", "changetime");
            if (ret == "")
            {
                ret = "3600000";
            }
            return int.Parse(ret);
        }
    }
}
