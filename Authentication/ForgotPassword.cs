using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using Dental.Services;
using Dental.DatabaseConnection;

namespace Dental.Authentication
{
    public partial class ForgotPassword : Form
    {
        private string? email;
        private string? generatedCode;
        private string? code;
        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        public ForgotPassword()
        {
            InitializeComponent();
            CodeTxt.Enabled = false;
            SubmitBtn.Enabled = false;
            _sqlconnection = new SqlConnection(_connection.connectionString);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login._instance.Show();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SubmitCode();
        }

        private void CodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerifyEmail_Click(object sender, EventArgs e)
        {
            email = EmailTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email first.");
                return;
            }

            if (!EmailExists(email))
            {
                MessageBox.Show("Email is not registered.");
                AppService.ClearFields(new List<TextBox> { EmailTxt });
                return;
            }

            SendOTP();


        }

        private void SendOTP()
        {
            email = EmailTxt.Text;
            generatedCode = new Random().Next(100000, 999999).ToString();

            try
            {
                string htmlBody = $@"<html>
                    <body style=""font-family: Arial, sans-serif; background-color: #1e1e1e; padding: 20px; margin: 0;"">
                        <div style=""max-width: 600px; margin: auto; background-color: #2b2b2b; border-radius: 8px; overflow: hidden;"">
                            <div style=""background-color: #FFD700; padding: 15px; text-align: center;"">
                                <h1 style=""color: #1e1e1e; margin: 0;"">Jaicten Dental Clinic</h1>
                            </div>
                            <div style=""padding: 20px; color: #f5f5f5 !important; -webkit-text-fill-color: #f5f5f5 !important;"">
                                <h2 style=""color: #FFD700 !important; margin-top: 0;"">Password Reset Request</h2>
                                <p style=""color: #f5f5f5 !important; margin: 0 0 10px 0;"">Hello,</p>
                                <p style=""color: #f5f5f5 !important; margin: 0 0 10px 0;"">
                                    We received a request to reset your password. Use the verification code below to proceed:
                                </p>
                                <p style=""font-size: 24px; font-weight: bold; text-align: center; color: #FFD700 !important; background-color: #2b2b2b; -webkit-text-fill-color: #FFD700 !important; text-decoration: none !important; padding: 10px; border-radius: 6px; user-select: text; margin: 20px 0;"">
                                    {generatedCode}
                                </p>
                                <p style=""color: #f5f5f5 !important; margin: 0;"">
                                    If you did not request a password reset, please ignore this email.
                                </p>
                            </div>
                            <div style=""background-color: #FFD700; text-align: center; padding: 10px; color: #1e1e1e;"">
                                <small>© 2025 Jaicten Dental Clinic. All rights reserved.</small>
                            </div>
                        </div>
                    </body>
                    </html>";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("testingprod44@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Your Password Reset Code";
                mail.Body = htmlBody;
                mail.IsBodyHtml = true; 

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("testingprod44@gmail.com", "bxfqtvorfoafpmpb");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Verification code sent to your email.");

                CodeTxt.Enabled = true;
                EmailTxt.Enabled = false;
                SubmitBtn.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }

        }
        private bool EmailExists(string email)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM regis_tab WHERE email = @Email";

            using (SqlCommand cmd = new SqlCommand(query, _sqlconnection))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                _sqlconnection.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }

            return exists;
        }
       

        private void SubmitCode()
        {
            code = CodeTxt.Text;
            if(generatedCode!= code)
            {

                AppService.MessageBoxState("Error", "Code is invalid");
                AppService.ClearFields(new List<TextBox> { CodeTxt });

                return;
            }

            var p = new ChangePassword(email);
            p.Show();
            this.Close();

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
