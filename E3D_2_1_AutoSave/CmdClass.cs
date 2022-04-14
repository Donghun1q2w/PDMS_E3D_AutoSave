using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aveva.ApplicationFramework.Presentation;

namespace AutoSave.ehdgns
{
    class CmdClass : Command
    {
        DockedWindow form;
        MainForm mainForm;
        bool chkIsOpen;
        public CmdClass( WindowManager windowManager , MainForm mf)
        {
            if (windowManager == null)
                throw new ArgumentNullException(nameof(windowManager));
            if (mf == null)
                throw new ArgumentNullException(nameof(mf));
            mainForm = mf;
            Key = "AutoSave.ehdgns";
            form = windowManager.CreateDockedWindow("AutoSave", "AutoSave", mainForm , DockedPosition.Floating );
            form.SaveLayout = true;
            form.Closed += Form_Closed;
            windowManager.WindowLayoutLoaded += WindowManager_WindowLayoutLoaded;
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            chkIsOpen = false;
        }

        private void WindowManager_WindowLayoutLoaded(object sender, EventArgs e)
        {
            chkIsOpen = form.Visible;
        }
        public override void Execute()
        {
            if(chkIsOpen)
                form.Hide();
            else
                form.Show();
            base.Execute();
        }
    }
}
