using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingApp
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">
        /// param1:function number 
        /// param2-N: function params,ATTENTION:exe 执行文件的后缀不能有某些特殊字符，所以不能传递路径
        /// </param>
        public static void Main(string[] args)
        {           
            int num = 0;
            if (args.Length > 0)
            {
                num = Convert.ToInt32(args[0]);
            }               
            switch (num)
            {
                case 1:
                    bool isAutoRun = Convert.ToBoolean(args[1]);                    
                    AutoRun(isAutoRun);
                    break;
                case 2:                    
                    getRegisteryAutoRun();
                    break;
                default:                   
                    break;
            }   
        }    
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IsAutoRun">是否自动启动</param>           
        public static void AutoRun(bool IsAutoRun)
        {
            string startupPath = Environment.CurrentDirectory + "\\WindowsSpotlightWallpaper.exe";
            //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.         
            RegistryKey loca_chek = Registry.LocalMachine;
            RegistryKey run = loca_chek.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",true);//打开注册表子项        
            //SetValue:存储值的名称
            if (IsAutoRun == false)
            {
                run.DeleteValue("WindowsSpotlight",false);
            }
            else
            {
                run.SetValue("WindowsSpotlight", startupPath);//设置开机运行
            }
            run.Close();
        }

        private static string settingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\spolightwallpaper\\settings.ini";

        public static void getRegisteryAutoRun()        
        {
            string inipath = settingpath;
            IniHandler handler = new IniHandler();
            handler.init(inipath);
            if (!handler.ExistINIFile())
            {
                handler.CreateFile();
            }
            string isAutoRun="false";
            RegistryKey loca_chek = Registry.LocalMachine;
            RegistryKey run_Check = loca_chek.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (run_Check.GetValue("WindowsSpotlight") == null)
            {
                isAutoRun= "false";
            }          
            else
            {
                isAutoRun = "true";
            }

            handler.IniWriteValue("basic", "autorun", isAutoRun);
        }
    }
}
