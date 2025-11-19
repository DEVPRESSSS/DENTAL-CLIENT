using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental.Authentication
{
    public partial class ForgotPassword : Form
    {
        private string? email;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login._instance.Show();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }

        private void CodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerifyEmail_Click(object sender, EventArgs e)
        {
            //Verify first the email



            //If exist send the 6 digits code to the email


        }

        private void SendOTP()
        {


        }
        private string EmailExist(string email)
        {


            return email;
        }

        private void SubmitCode()
        {


        }

        private void EmailTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void EmailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            Services.ValidationServices.NoSpace(sender, e);

        }

        private void EmailTxt_Leave(object sender, EventArgs e)
        {
            email = EmailTxt.Text.Trim();
            var emailFormat = Services.ValidationServices.ValidateEmail(email);
            if(emailFormat== true ) Services.AppService.ClearFields(new List<TextBox> { EmailTxt});
        }
    }
}
