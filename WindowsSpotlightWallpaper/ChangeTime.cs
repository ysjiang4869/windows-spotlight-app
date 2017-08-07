using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsSpotlightWallpaper.service;

namespace WindowsSpotlightWallpaper
{
    public partial class ChangeTime : Form
    {
        public ChangeTime(SettingService settingService)
        {
            InitializeComponent();
            this.set = settingService;
            init();            
        }

        private  void init()
        {
            changeTime = set.getChangeTime();
            int seconds = changeTime / 1000;
            int hour = seconds /3600;
            int minute = (seconds % 3600) / 60;
            this.comboBox1.Text=hour.ToString();
            this.comboBox2.Text=minute.ToString();
        }

        private int changeTime=3600000;
        private SettingService set;

        private void OkButton_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(this.comboBox1.SelectedItem.ToString());
            int minute = int.Parse(this.comboBox2.SelectedItem.ToString());
            changeTime = (hour * 3600 + minute * 60) * 1000;
            set.setChangeTime(changeTime);
            this.Close();
        }
    }
}
