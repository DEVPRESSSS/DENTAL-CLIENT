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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dental.Areas.Usercontrols
{
    public partial class PrescriptionUC : UserControl
    {
        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        private string? fullName;
        private string? treatment;
        private int selectedPrescriptionId = -1;
        public PrescriptionUC()
        {
            InitializeComponent();
            _sqlconnection = new SqlConnection(_connection.connectionString);

            LoadPatients();
            LoadServices();
            LoadPrescriptions();
            LimitAccess();

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
            AddPrescription();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdatePrescription();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {

            if (selectedPrescriptionId == -1)
            {
                AppService.MessageBoxState("Error", "Select a record to delete.");

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
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM prescription WHERE prescription_id=@id", _sqlconnection);
                cmd.Parameters.AddWithValue("@id", selectedPrescriptionId);
                _sqlconnection.Open();
                cmd.ExecuteNonQuery();
                _sqlconnection.Close();

                AppService.MessageBoxState("Information", "Deleted prescription successfully");
                LoadPrescriptions();
                Clear();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) 
                {
                    MessageBox.Show("Cannot delete this prescription because it has related records. Please delete those first.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            finally
            {
                if (_sqlconnection.State == ConnectionState.Open)
                    _sqlconnection.Close();
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddPrescription()
        {
            try
            {
                if (Fullnamecb.SelectedItem is not KeyValuePair<int, string> patient ||
                TreatmentCb.SelectedItem is not KeyValuePair<int, string> service)
                {
                    AppService.MessageBoxState("Error", "Please select patient and service.");

                    return;
                }

                var b = ValidationServices.RequireFields(new List<string> { AllergiesTxt.Text });
                if (b == true)
                {
                    AppService.MessageBoxState("Error", "All fields are required");

                    return;
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO prescription (appointment_id, treatment_id, allergies) VALUES (@appointment_id, @service_id, @allergies)", _sqlconnection);
                cmd.Parameters.AddWithValue("@appointment_id", patient.Key);
                cmd.Parameters.AddWithValue("@service_id", service.Key);
                cmd.Parameters.AddWithValue("@allergies", AllergiesTxt.Text);


                _sqlconnection.Open();
                cmd.ExecuteNonQuery();
                AppService.MessageBoxState("Information", "Prescription added successfully");
                LoadPrescriptions();
                Clear();

            }
            catch (SqlException ex)
            {

                AppService.MessageBoxState("Error", ex.Message);


            }
            finally
            {
                _sqlconnection.Close();
            }


        }

        private void Clear()
        {
            Fullnamecb.SelectedItem = null;
            TreatmentCb.SelectedItem = null;
            AppService.ClearFields(new List<System.Windows.Forms.TextBox> { AllergiesTxt });
        }

        private void LoadPatients()
        {
            Fullnamecb.Items.Clear();

            Fullnamecb.DisplayMember = "Value";
            Fullnamecb.ValueMember = "Key";


            try
            {
                _sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT appointment_id, name FROM appointment", _sqlconnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Fullnamecb.Items.Add(new KeyValuePair<int, string>(
                        (int)dr["appointment_id"],
                        dr["name"].ToString()
                    ));
                }

            }
            catch (Exception ex)
            {
                AppService.MessageBoxState("Error", ex.Message);

            }
            finally
            {

                _sqlconnection.Close();

            }

        }

        private void LoadServices()
        {
            TreatmentCb.Items.Clear();

            TreatmentCb.DisplayMember = "Value";
            TreatmentCb.ValueMember = "Key";

            try
            {
                _sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT service_id, service_name FROM services", _sqlconnection);
                SqlDataReader dr = cmd.ExecuteReader();

                bool hasRows = false;
                while (dr.Read())
                {
                    hasRows = true;
                    TreatmentCb.Items.Add(new KeyValuePair<int, string>(
                        (int)dr["service_id"],
                        dr["service_name"].ToString()
                    ));
                }

                if (!hasRows)
                {
                    AppService.MessageBoxState("Error", "No service found!");
                }
            }
            catch (Exception ex)
            {
                AppService.MessageBoxState("Error", ex.Message);
            }
            finally
            {
                _sqlconnection.Close();

            }
        }

        private void LoadPrescriptions()
        {
            string query = @"
                    SELECT 
                        p.prescription_id,
                        a.name AS patient_name,
                        s.service_name AS treatment_name,
                        a.phone,
                        a.gender,
                        p.allergies
                    FROM 
                        prescription p
                    INNER JOIN 
                        appointment a ON p.appointment_id = a.appointment_id
                    INNER JOIN 
                        services s ON p.treatment_id = s.service_id;";

            SqlDataAdapter da = new SqlDataAdapter(query, _sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedPrescriptionId = Convert.ToInt32(row.Cells["prescription_id"].Value);

                foreach (KeyValuePair<int, string> item in Fullnamecb.Items)
                {
                    if (item.Value == row.Cells["patient_name"].Value.ToString())
                    {
                        Fullnamecb.SelectedItem = item;
                        break;
                    }
                }

            
                foreach (KeyValuePair<int, string> item in TreatmentCb.Items)
                {
                    if (item.Value == row.Cells["treatment_name"].Value.ToString())
                    {
                        TreatmentCb.SelectedItem = item;
                        break;
                    }
                }

                AllergiesTxt.Text = row.Cells["allergies"].Value.ToString();
            }
        }

        private void UpdatePrescription()
        {

            if (selectedPrescriptionId == -1)
            {
                MessageBox.Show("Select a record to update.");
                return;
            }

            if (Fullnamecb.SelectedItem is not KeyValuePair<int, string> patient ||
                TreatmentCb.SelectedItem is not KeyValuePair<int, string> treatment)
            {
                AppService.MessageBoxState("Error", "Please select patient and treatment");
                return;
            }

            try
            {

                SqlCommand cmd = new SqlCommand("UPDATE prescription SET appointment_id=@appointment_id, treatment_id=@treatment_id, allergies=@allergies WHERE prescription_id=@id", _sqlconnection);
                cmd.Parameters.AddWithValue("@appointment_id", patient.Key);
                cmd.Parameters.AddWithValue("@treatment_id", treatment.Key);
                cmd.Parameters.AddWithValue("@allergies", AllergiesTxt.Text);
                cmd.Parameters.AddWithValue("@id", selectedPrescriptionId);

                _sqlconnection.Open();
                cmd.ExecuteNonQuery();
                _sqlconnection.Close();

                AppService.MessageBoxState("Information", "Prescription updated");
                LoadPrescriptions();
                Clear();
            }catch (Exception ex)
            {
                AppService.MessageBoxState("Error", ex.Message);

            }
            finally
            {
                _sqlconnection.Close();
            }
          
        }
    }
}
