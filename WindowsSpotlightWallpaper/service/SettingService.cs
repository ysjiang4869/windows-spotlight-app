﻿using System;
using System.Diagnostics;

using System.Windows.Forms;

namespace WindowsSpotlightWallpaper.service
{
    public class SettingService
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                     "\\spolightwallpaper\\settings.ini";

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

        public bool AutoRun
        {
            get
            {
                string ret = handler.IniReadValue("basic", nameof(AutoRun));
                if (ret == "")
                {
                    string[] args = {"2"};
                    runSettingApp(args);
                    ret = handler.IniReadValue("basic", nameof(AutoRun));
                }

                return bool.TryParse(ret, out bool result) && result;
            }
            set
            {
                string[] args = {"1", value.ToString()};
                runSettingApp(args);
                handler.IniWriteValue("basic", nameof(AutoRun), value.ToString());
            }
        }

        public bool MinimizedOnStartup
        {
            get
            {
                string ret = handler.IniReadValue("basic", nameof(MinimizedOnStartup));
                return bool.TryParse(ret, out bool result) && result;
            }
            set => handler.IniWriteValue("basic", nameof(MinimizedOnStartup), value.ToString());
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

        public bool AutoChange 
        {
            get
            {
                string ret = handler.IniReadValue("basic", nameof(AutoChange).ToLower());
                return bool.TryParse(ret, out bool result) && result;
            }
            set => handler.IniWriteValue("basic", nameof(AutoChange).ToLower(), value.ToString());
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