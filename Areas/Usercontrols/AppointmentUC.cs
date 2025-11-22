using Dental.DatabaseConnection;
using Dental.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental.Areas.Usercontrols
{
    public partial class AppointmentUC : UserControl
    {

        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        private string? fullName;
        private string? phone;
        private string? address;
        private DateOnly? date;
        private int selectedId = -1;
        public AppointmentUC()
        {
            InitializeComponent();
            _sqlconnection = new SqlConnection(_connection.connectionString);
            gendercb.SelectedIndex = 0;
            LoadAppointments();
            LimitAccess();
            appointmentDate.MinDate = DateTime.Today;
            appointmentDate.Value = DateTime.Today;


        }

        private void LimitAccess()
        {

            if (UserService.Role == "Staff")
            {
                DeleteBtn.Visible = false;

            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }

        //Add function
        private void AddAppointment()
        {

            try
            {
                fullName = FullnameTxt.Text;
                phone = PhoneTxt.Text;
                address = AddressTxt.Text;

                var checkIfEmpty = Services.ValidationServices.RequireFields(new List<string> { fullName, phone, address });
                if (checkIfEmpty == true)
                {
                    Services.AppService.MessageBoxState("Error", "All fields are required!");

                    return;
                }
                if (phone.Length < 11)
                {
                    Services.AppService.MessageBoxState("Error", "Phone must be 11 digits");
                    return;

                }


                SqlCommand cmd = new SqlCommand("INSERT INTO appointment (name, phone, address, dob, gender, appointmentdate) VALUES (@name, @phone, @address, @dob, @gender, @appointmentdate)", _sqlconnection);
                cmd.Parameters.AddWithValue("@name", FullnameTxt.Text);
                cmd.Parameters.AddWithValue("@phone", PhoneTxt.Text);
                cmd.Parameters.AddWithValue("@address", AddressTxt.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@gender", gendercb.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@appointmentdate", appointmentDate.Value.Date);

                _sqlconnection.Open();
                cmd.ExecuteNonQuery();

                Services.AppService.MessageBoxState("Information", "Appointment added successfully");
                LoadAppointments();
            }
            catch (SqlException ex)
            {
                Services.AppService.MessageBoxState("Error", "Something went wron" + ex);
            }
            finally
            {
                _sqlconnection.Close();

                Clear();
            }

        }

        //Clear all fields
        private void Clear()
        {
            dateTimePicker1.Value = DateTime.Now;
            gendercb.SelectedItem = null;
            appointmentDate.Value = DateTime.Now;
            Services.AppService.ClearFields(new List<TextBox> { FullnameTxt, PhoneTxt, AddressTxt });
        }

        //Fetch the appointments
        private void LoadAppointments()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM appointment", _sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AppointmentTbl.AllowUserToResizeColumns = false;

            AppointmentTbl.DataSource = dt;
        }

        //Call the update function
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateAppointment();
        }

        private void UpdateAppointment()
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            fullName = FullnameTxt.Text;
            phone = PhoneTxt.Text;

            address = AddressTxt.Text;

            var checkIfEmpty = Services.ValidationServices.RequireFields(new List<string> { fullName, phone, address });
            if (checkIfEmpty == true)
            {
                Services.AppService.MessageBoxState("Error", "All fields are required!");
                return;
            }
            if (phone.Length < 11)
            {
                Services.AppService.MessageBoxState("Error", "Phone must be 11 digits");
                return;

            }
            //if (int.TryParse(phone, out int _phone))
            //{

            //    if (_phone <= 11)
            //    {
            //        Services.AppService.MessageBoxState("Error", "Phone must be 11 digits");
            //        return;
            //    }

            //}

            SqlCommand cmd = new SqlCommand("UPDATE appointment SET name=@name, phone=@phone, address=@address, dob=@dob, gender=@gender, appointmentdate=@appointmentdate WHERE appointment_id=@id", _sqlconnection);
            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@gender", gendercb.SelectedItem?.ToString());
            cmd.Parameters.AddWithValue("@appointmentdate", appointmentDate.Value.Date);
            _sqlconnection.Open();
            cmd.ExecuteNonQuery();
            _sqlconnection.Close();

            Services.AppService.MessageBoxState("Information", "Appointment updated successfully");
            LoadAppointments();
            Clear();

        }
        //Row and data selection
        private void AppointmentTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AppointmentTbl.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["appointment_id"].Value);
                FullnameTxt.Text = row.Cells["name"].Value.ToString();
                PhoneTxt.Text = row.Cells["phone"].Value.ToString();
                AddressTxt.Text = row.Cells["address"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["dob"].Value);
                gendercb.SelectedItem = row.Cells["gender"].Value.ToString();
                appointmentDate.Value = Convert.ToDateTime(row.Cells["appointmentdate"].Value);
            }
        }

        //Delete specific appointment
        private void DeleteAppointment()
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
                SqlCommand deletePrescriptionsCmd = new SqlCommand("DELETE FROM appointment WHERE appointment_id = @id", _sqlconnection);
                deletePrescriptionsCmd.Parameters.AddWithValue("@id", selectedId);
                deletePrescriptionsCmd.ExecuteNonQuery();


                _sqlconnection.Close();

                Services.AppService.MessageBoxState("Information", "Appointment deleted successfully");
                LoadAppointments();


            }
            catch
            {
                Services.AppService.MessageBoxState("Error", "This patient has related records");
            }
            finally
            {
                _sqlconnection.Close();
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAppointment();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FullnameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Services.ValidationServices.PersonNameTextComposition(sender, e);
        }

        private void FullnameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            //Services.ValidationServices.NoSpace(sender, e);

        }

        private void PhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Services.ValidationServices.AllowOnlyNumbers(sender, e);
        }

        private void AppointmentUC_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2018,1,1);

        }
    }
}
