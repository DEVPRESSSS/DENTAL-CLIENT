namespace Dental
{
    public partial class Login : Form
    {
        private string? _email;
        private string? _password;
        public Login()
        {
            InitializeComponent();
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

            if(string.IsNullOrEmpty(_email) || string.IsNullOrEmpty(_password))
            {
                Services.AppService.MessageBoxState("Error", "All fields are required");
                Services.AppService.ClearFields(new List<TextBox> { EmailTxt, PasswordTxt });

                return;
            }

        }


    
    }
}
