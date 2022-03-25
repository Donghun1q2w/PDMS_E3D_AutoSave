using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aveva.Core.Utilities.CommandLine;

namespace AutoSave.ehdgns
{
    public partial class MainForm : UserControl
    {
        public MainForm()
        {
            InitializeComponent();

        }
        void Save()
        {
            Command command = Command.CreateCommand("!!alert.message('aasfdsfd')");
            command.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
