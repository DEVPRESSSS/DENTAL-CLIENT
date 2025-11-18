using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Services
{
    public class AppService
    {
        //This will clear all the value of textboxes
        public static void ClearFields(List<TextBox> textBox)
        {
            foreach (TextBox tb in textBox)
            {
                tb.Clear();
            }

        }

        //MessageBoxes service
        public static void MessageBoxState(string title, string message)
        {

            switch(title.ToLower())
            {
                case "information":
                    MessageBox.Show(title, message,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case "error":
                    MessageBox.Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }


        }

        //Usercontrol management 
        public static void ShowPanel(Panel panel, UserControl control)
        {
            
            panel.Visible = true;
            panel.Controls.Clear();

            control.Dock = DockStyle.Fill;

            panel.Controls.Add(control);

        }
    }
}
