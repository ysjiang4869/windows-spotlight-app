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
        /// param2-N: function params
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
                    string startupPath = args[2];
                    AutoRun(isAutoRun, startupPath);
                    break;
                case 2:
                    string inipath = args[1];
                    getRegisteryAutoRun(inipath);
                    break;
                default:                   
                    break;
            }           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IsAutoRun">是否自动启动</param>
        /// <param name="startupPath">程序启动路径</param>        
        public static void AutoRun(bool IsAutoRun,string startupPath)
        {                    
            //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.
            RegistryKey loca = Registry.LocalMachine;
            RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");

            //SetValue:存储值的名称
            if (IsAutoRun == false) run.SetValue("WindowsSpotlight", false);//取消开机运行
            else run.SetValue("WindowsSpotlight", startupPath);//设置开机运行
            loca.Close();
        }

        public static void getRegisteryAutoRun(string inipath)        
        {
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
            if (run_Check.GetValue("WindowsSpotlight").ToString().ToLower() != "false")
            {
                isAutoRun = "true";
            }
            else
            {
                isAutoRun = "false";
            }

            handler.IniWriteValue("basic", "autorun", isAutoRun);
        }
    }
}
