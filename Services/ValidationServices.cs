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
    }
}
