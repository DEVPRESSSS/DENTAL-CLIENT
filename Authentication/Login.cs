using Dental.Areas.Admin;
using Dental.Areas.StaffDasboard;
using Dental.Authentication;
using Dental.DatabaseConnection;
using Dental.Services;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dental
{
    public partial class Login : Form
    {
        private string? _email;
        private string? _password;

        public static Login _instance;
        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        public Login()
        {
            InitializeComponent();
            _instance = this;
            _sqlconnection = new SqlConnection(_connection.connectionString);

        }

        //Close the form
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Services.FormService.CloseForm(this);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Authentication();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            Services.FormService.FormBorderStyleNavigation(this, "Minimize");

        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            Services.FormService.FormBorderStyleNavigation(this, "Maximize");

        }

        private void EmailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            Services.ValidationServices.NoSpace(sender, e);
        }

        private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            Services.ValidationServices.NoSpace(sender, e);
        }


        private void Authentication()
        {
            _email = EmailTxt.Text.Trim();
            _password = PasswordTxt.Text.Trim();

            if (string.IsNullOrEmpty(_email) || string.IsNullOrEmpty(_password))
            {
                Services.AppService.MessageBoxState("Error", "All fields are required");
                Services.AppService.ClearFields(new List<TextBox> { EmailTxt, PasswordTxt });

                return;
            }

            try
            {
                _sqlconnection.Open();

                string query = "SELECT firstname, lastname, email, password, RoleName, AppUserId " +
                               "FROM regis_tab WHERE email = @email AND password = @password";

                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                cmd.Parameters.AddWithValue("@email", _email);
                cmd.Parameters.AddWithValue("@password", _password);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string? role = dr["RoleName"].ToString();
                    UserService.SetUserRole(role);

                    if (role == "Admin")
                    {

                        AdminLayout adminForm = new AdminLayout();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (role == "Staff")
                    {

                        StaffLayout staffForm = new StaffLayout();
                        staffForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        AppService.MessageBoxState("Error", "Invalid username of password");
                    }
                }
                else
                {
                    AppService.MessageBoxState("Error", "Invalid username of password");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                _sqlconnection.Close();
                Services.AppService.ClearFields(new List<TextBox> { EmailTxt, PasswordTxt });

            }

        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Services.FormService.ShowFormAndHide(new ForgotPassword());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
