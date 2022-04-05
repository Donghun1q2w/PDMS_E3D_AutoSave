using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSave.ehdgns
{
    internal class RefineTextBox
    {
        public void SetTextBox(TextBox sender, MainForm form, Panel back_Panel)
        {
            sender.Font = new System.Drawing.Font("Microsoft Sans Serif", sender.Font.Size);
            sender.BackColor = form.BackColor;
            sender.BorderStyle = BorderStyle.None;
            sender.ForeColor = form.ForeColor;
            Panel underline = new Panel();
            underline.BackColor = form.ForeColor;
            underline.BorderStyle = BorderStyle.None;
            underline.Size = new System.Drawing.Size(sender.Width + 2, 1);
            underline.Location = new System.Drawing.Point(sender.Location.X - 1, sender.Location.Y + sender.Size.Height - 1);
            back_Panel.Controls.Add(underline);
            underline.BringToFront();
        }
    }
}
