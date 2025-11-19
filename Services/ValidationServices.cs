using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Services
{
    public class ValidationServices
    {

        public ValidationServices() { }

        
        public static void NoSpace(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;   
            }
        }

        public static bool ValidateEmail(string email)
        {
            if (!email.ToLower().EndsWith("@gmail.com"))
            {
                Services.AppService.MessageBoxState("Error", "Email input is invalid");
                return true;
            }

            return false;


        }

        public static bool RequireFields(List<string> inputs)
        {
            foreach (var box in inputs)
            {
                if (string.IsNullOrEmpty(box))
                {
                    
                    return true ;
                  

                }
            }

            return false;
        }
    }
}
