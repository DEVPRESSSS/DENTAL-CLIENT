using Dental.DatabaseConnection;
using Dental.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental.Areas.Usercontrols
{
    public partial class Staff : UserControl
    {
        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        private string? FirstName;
        private string? MiddleName;
        private string? Email;
        private string? Password;
        private DateOnly? date;
        private int selectedId = -1;
        public Staff()
        {
            InitializeComponent();
            _sqlconnection = new SqlConnection(_connection.connectionString);
            LoadStaff();
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStaff();
        }
        private void AddStaff()
        {
            try
            {
                FirstName = FirstnameTxt.Text;
                MiddleName = MiddleNameTxt.Text;
                Email = EmailTxt.Text;
                Password = PasswordTxt.Text;

                var checkIfEmpty = Services.ValidationServices.RequireFields(new List<string> { FirstName, MiddleName, Email, Password });
                if (checkIfEmpty == true)
                {
                    Services.AppService.MessageBoxState("Error", "All fields are required!");

                    return;
                }


                SqlCommand cmd = new SqlCommand("INSERT INTO regis_tab (firstname, lastname, email, password, RoleName) VALUES (@firstname, @lastname, @email, @password, @RoleName)", _sqlconnection);
                cmd.Parameters.AddWithValue("@firstname", FirstName);
                cmd.Parameters.AddWithValue("@lastname", MiddleName);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@RoleName", "Staff");

                _sqlconnection.Open();
                cmd.ExecuteNonQuery();

                Services.AppService.MessageBoxState("Information", "Staff added successfully");
            }
            catch (SqlException ex)
            {
                Services.AppService.MessageBoxState("Error", "Email or Contact are already taken" + ex);
            }
            finally
            {
                _sqlconnection.Close();
                Clear();
            }


        }

        private void Clear()
        {

            Services.AppService.ClearFields(new List<TextBox> { FirstnameTxt, MiddleNameTxt, EmailTxt, PasswordTxt });
            PasswordTxt.Enabled = true;
        }

        //Fetch staff
        private void LoadStaff()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM regis_tab WHERE RoleName <> 'Admin'", _sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            StaffTable.DataSource = dt;

            if (StaffTable.Columns.Contains("password"))
            {
                StaffTable.Columns["password"].Visible = false;
            }
        }


        private void UpdateStaff()
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            FirstName = FirstnameTxt.Text;
            MiddleName = MiddleNameTxt.Text;
            Email = EmailTxt.Text;
            Password = PasswordTxt.Text;

            var checkIfEmpty = Services.ValidationServices.RequireFields(new List<string> { FirstName, MiddleName, Email });
            if (checkIfEmpty == true)
            {
                Services.AppService.MessageBoxState("Error", "All fields are required!");

                return;
            }




            SqlCommand cmd = new SqlCommand("UPDATE regis_tab SET firstname=@firstname, lastname=@lastname, email=@email, password=@password WHERE AppUserId=@AppUserId", _sqlconnection);
            cmd.Parameters.AddWithValue("@AppUserId", selectedId);
            cmd.Parameters.AddWithValue("@firstname", FirstName);
            cmd.Parameters.AddWithValue("@lastname", MiddleName);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Password);
            _sqlconnection.Open();
            cmd.ExecuteNonQuery();
            _sqlconnection.Close();

            Services.AppService.MessageBoxState("Information", "Staff updated successfully");
            LoadStaff();
            Clear();

        }


        private void DeleteStaff()
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
            {
                return;
            }
            _sqlconnection.Open();

            try
            {
                SqlCommand deletePrescriptionsCmd = new SqlCommand("DELETE FROM regis_tab WHERE AppUserId = @AppUserId", _sqlconnection);
                deletePrescriptionsCmd.Parameters.AddWithValue("@AppUserId", selectedId);
                deletePrescriptionsCmd.ExecuteNonQuery();



                Services.AppService.MessageBoxState("Information", "Staff deleted successfully");
                LoadStaff();

            }
            catch
            {
                Services.AppService.MessageBoxState("Error", "Error while deleting..");
            }
            finally
            {
                _sqlconnection.Close();
                Clear();

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateStaff();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }

        private void StaffTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StaffTable.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["AppUserId"].Value);
                FirstnameTxt.Text = row.Cells["firstname"].Value.ToString();
                MiddleNameTxt.Text = row.Cells["lastname"].Value.ToString();
                EmailTxt.Text = row.Cells["email"].Value.ToString();
                PasswordTxt.Enabled = false;
            }
        }

        private void EmailTxt_Leave(object sender, EventArgs e)
        {
            var emailValidation = ValidationServices.ValidateEmail(EmailTxt.Text);
            if (emailValidation == true) EmailTxt.Clear();
        }

        private void MiddleNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationServices.PersonNameTextComposition(sender, e);
        }

        private void FirstnameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationServices.PersonNameTextComposition(sender, e);
        }

        private void EmailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            ValidationServices.NoSpace(sender, e);

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
