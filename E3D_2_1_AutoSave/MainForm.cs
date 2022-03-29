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

namespace AutoSave.ehdgns
{
    public partial class MainForm : UserControl
    {
        Timer timer = new Timer();
        Stopwatch stopwatch = new Stopwatch();
        public MainForm()
        {
            InitializeComponent();
        }
        private void Start_Button_Event(object sender, EventArgs e)
        {
            stopwatch.Restart();
            timer.Enabled = true;
            timer.Interval = 10000;
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
    }
}
