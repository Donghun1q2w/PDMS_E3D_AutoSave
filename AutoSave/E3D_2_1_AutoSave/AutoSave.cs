using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;

namespace AutoSave.ehdgns
{
    public class AutoSave : IAddin
    {
        MainForm mainForm;
        public string Description
        {
            get { return "AutoSave made by DHL"; }
        }
        public string Name
        { get { return "AutoSave"; } }
        public void Start(ServiceManager serviceManager)
        {
            //MessageBox.Show("shown");
            CommandManager commandManager = (CommandManager)serviceManager.GetService(typeof(CommandManager));
            WindowManager windowManager = (WindowManager)serviceManager.GetService(typeof(WindowManager));
            mainForm = new MainForm();
            commandManager.Commands.Add(new CmdClass(windowManager, mainForm));
        }


        public void Stop()
        {

        }
    }
}
