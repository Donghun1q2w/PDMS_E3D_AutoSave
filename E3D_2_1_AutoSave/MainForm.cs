using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aveva.Core.Utilities.CommandLine;
using System.Diagnostics;
using ehdgns = AutoSave.ehdgns;

namespace AutoSave.ehdgns
{
    public partial class MainForm : UserControl
    {
        Timer timer = new Timer();
        Stopwatch stopwatch = new Stopwatch();
        public MainForm()
        {
            InitializeComponent();
            RefineTextBox refineTextBox = new RefineTextBox();
            refineTextBox.SetTextBox(Txt_Hour, this, panel2);
            refineTextBox.SetTextBox(Txt_Min, this, panel2);
            refineTextBox.SetTextBox(Txt_Sec, this, panel2);
            Txt_Hour.Text = ehdgns.Properties.Settings1.Default.Hour.ToString();
            Txt_Min.Text =  ehdgns.Properties.Settings1.Default.Min.ToString();
            Txt_Sec.Text =  ehdgns.Properties.Settings1.Default.Sec.ToString();
            Txt_Hour.TextChanged += IntervalChangingEvent;
        }

        private void IntervalChangingEvent(object sender, EventArgs e)
        {
                TextBox sen = (TextBox)sender;
            try
            {
                int chk = Convert.ToInt16(((TextBox)sen).Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Integer must be inserted!!!");
                sen.Text = "0";
                return;
            }
            ehdgns.Properties.Settings1.Default.Hour = GetTime(Txt_Hour.Text);
            ehdgns.Properties.Settings1.Default.Min = GetTime(Txt_Min.Text);
            ehdgns.Properties.Settings1.Default.Sec = GetTime(Txt_Sec.Text);
            ehdgns.Properties.Settings1.Default.Save();
        }

        private void Start_Button_Event(object sender, EventArgs e)
        {
            stopwatch.Restart();
            timer.Enabled = true;
            timer.Interval = GetInterval(GetTime(Txt_Hour.Text) , GetTime(Txt_Min.Text), GetTime(Txt_Sec.Text));
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Command command = Command.CreateCommand("!!alert.message('aasfdsfd')");
            command.Run();
        }
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled=false;
            stopwatch.Stop();
        }
        int GetInterval(int hour, int  min , int sec)
        {
            return (hour * 3600 + min * 60 + sec) * 100;
        }
        int GetTime(string time)
        {
            try
            {
                return Convert.ToInt32(time);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
    }
}
