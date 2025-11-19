using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private static readonly Regex _numberRegex = new Regex("^[0-9]+$");

        public static void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            string input = e.KeyChar.ToString();

            if (!_numberRegex.IsMatch(input) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }



        public static void UsernameTextComposition(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        //public static void EmailTextComposition(object sender, TextCompositionEventArgs e)
        //{
        //    char inputChar = e.Text[0];

        //    if (!char.IsLetterOrDigit(inputChar) &&
        //        inputChar != '@' &&
        //        inputChar != '.' &&
        //        inputChar != '-' &&
        //        inputChar != '_' &&
        //        inputChar != '+')
        //    {
        //        e.Handled = true;
        //    }
        //}

        //public static void IntegerTextCompositon(object sender, TextCompositionEventArgs e)
        //{
        //    if (!char.IsDigit(e.Text, 0) || char.IsWhiteSpace(e.Text, 0))
        //    {
        //        e.Handled = true;
        //    }
        //}

        public static void PersonNameTextComposition(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            char inputChar = e.KeyChar;

            // Allow Backspace
            if (inputChar == (char)Keys.Back)
                return;

            // Allow only letters and spaces
            if (!char.IsLetter(inputChar) && inputChar != ' ')
            {
                e.Handled = true;
                return;
            }

            // Prevent starting with space
            if (textBox.Text.Length == 0 && inputChar == ' ')
            {
                e.Handled = true;
                return;
            }

            // Prevent consecutive spaces
            if (inputChar == ' ' && textBox.Text.EndsWith(" "))
            {
                e.Handled = true;
            }
        }


    }
}
