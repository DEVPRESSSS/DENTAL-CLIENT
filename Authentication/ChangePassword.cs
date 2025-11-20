using Dental.DatabaseConnection;
using Dental.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dental.Authentication
{
    public partial class ChangePassword : Form
    {
        private string? _password;
        private string? _email;
        private string? _confirmPassword;
        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        public ChangePassword(string? email)
        {
            InitializeComponent();
            _sqlconnection = new SqlConnection(_connection.connectionString);
            _email = email;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string newPass = NewPassTxt.Text.Trim();
            string confirmPass = ConfirmPassTxt.Text.Trim();

           var b=  ValidationServices.RequireFields(new List<string> { confirmPass, newPass });
            if(b == true)
            {
                AppService.MessageBoxState("Error", "All fields are required!!");
                AppService.ClearFields(new List<TextBox> { NewPassTxt, ConfirmPassTxt });



                return;
            }

            if (newPass != confirmPass)
            {
                AppService.MessageBoxState("Error", "Password dont match!");
                AppService.ClearFields(new List<TextBox> { NewPassTxt, ConfirmPassTxt });

                return;
            }

            bool updated = UpdatePassword(_email, newPass);

            if (updated)
            {
                AppService.MessageBoxState("Information", "Password updated successfully");
                Login._instance.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update password. Email not found.");
            }
        }

        private bool UpdatePassword(string email, string newPassword)
        {

            string query = @"
                UPDATE regis_tab
                SET password = @Password
                WHERE email = @Email";

            using (SqlCommand cmd = new SqlCommand(query, _sqlconnection))
            {
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);

                _sqlconnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NewPassTxt.UseSystemPasswordChar = false;
                ConfirmPassTxt.UseSystemPasswordChar = false;
            }
            else
            {
               NewPassTxt.UseSystemPasswordChar = true;
               ConfirmPassTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
