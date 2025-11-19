using Dental.DatabaseConnection;
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
        public AppointmentUC()
        {
            _sqlconnection = new SqlConnection(_connection.connectionString);
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }

        private void AddAppointment()
        {

            try
            {
                fullName =FullnameTxt.Text;
                phone =PhoneTxt.Text;
                address =AddressTxt.Text;

                var checkIfEmpty = Services.ValidationServices.RequireFields(new List<string> { fullName,phone,address});
                if(checkIfEmpty == true)
                {
                    Services.AppService.MessageBoxState("Error", "All fields are required!");
                    Clear();
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
                Clear();
            }
            catch(SqlException ex)
            {
                Services.AppService.MessageBoxState("Error", "Something went wron" + ex);
            }
            finally
            {
                _sqlconnection.Close();
            }

        }

        private void Clear()
        {
            dateTimePicker1.Value = DateTime.Now;
            gendercb = null;
            appointmentDate.Value = DateTime.Now;
            Services.AppService.ClearFields(new List<TextBox> { FullnameTxt,PhoneTxt,AddressTxt});
        }

        private void LoadAppointments()
        {
            throw new NotImplementedException();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
