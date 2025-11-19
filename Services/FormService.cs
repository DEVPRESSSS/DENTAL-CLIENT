using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Services
{
    public class FormService
    {

        public FormService()
        {
            
        }

        //Close the form when called
        public static void CloseForm(Form form)
        {
            form.Close();
        }

        public static void FormBorderStyleNavigation(Form form, string windowState)
        {
            if (form == null) return;

            if(string.IsNullOrEmpty(windowState)) return ;

            if(form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;

            }
            else
            {
                form.WindowState = FormWindowState.Normal;

            }

            //Filter the windowState
            if (windowState.ToLower() == "minimize")
            {
                form.WindowState = FormWindowState.Minimized;
            }

        }

        public static void ShowFormAndHide(Form next)
        {
            if (next == null) return;

            next.Show();
        }

        

    }
}
