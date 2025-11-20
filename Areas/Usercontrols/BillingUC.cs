using Dental.DatabaseConnection;
using Dental.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace Dental.Areas.Usercontrols
{
    public partial class BillingUC : UserControl
    {
        private SqlConnection _sqlconnection;
        private readonly Connection _connection = new Connection();
        private string treatmentDesc;
        public BillingUC()
        {
            InitializeComponent();
            _sqlconnection = new SqlConnection(_connection.connectionString);

            LoadPatients();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("PrescriptionID", "Prescription ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Treatment", "Treatment");
            dataGridView1.Columns.Add("Cost", "Cost");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void LoadPatients()
        {
            try
            {
                _sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT appointment_id, name FROM appointment", _sqlconnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                PatientCb.DataSource = dt;
                PatientCb.DisplayMember = "name";
                PatientCb.ValueMember = "appointment_id";

                _sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                _sqlconnection.Close();

            }
        }
        private void GenerateReceipt_Click(object sender, EventArgs e)
        {
            //if (PatientCb.SelectedValue == null)
            //{
            //    MessageBox.Show("Please select a patient.");
            //    return;
            //}
            //var costLines = Cost.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //int appointmentId = (int)PatientCb.SelectedValue;
            //string costTextRaw = costLines[0].Replace("₱", "").Replace(",", "").Trim();

            //if (!decimal.TryParse(costTextRaw, out decimal treatmentCost))
            //{
            //    MessageBox.Show("Please enter a valid cost.");
            //    return;
            //}

            //try
            //{
            //    _sqlconnection.Open();

            //    string checkQuery = "SELECT service_id FROM services WHERE service_name = @desc";
            //    SqlCommand cmdCheck = new SqlCommand(checkQuery, _sqlconnection);
            //    cmdCheck.Parameters.AddWithValue("@desc", treatmentDesc);

            //    object existingServiceIdObj = cmdCheck.ExecuteScalar();
            //    int serviceId;

            //    if (existingServiceIdObj != null)
            //    {
            //        serviceId = (int)existingServiceIdObj;
            //    }
            //    else
            //    {
            //        string insertServiceQuery = "INSERT INTO services (service_name, cost) OUTPUT INSERTED.service_id VALUES (@desc, @cost)";
            //        SqlCommand cmdInsertService = new SqlCommand(insertServiceQuery, _sqlconnection);
            //        cmdInsertService.Parameters.AddWithValue("@service_name", treatmentDesc);
            //        cmdInsertService.Parameters.AddWithValue("@cost", treatmentCost);

            //        serviceId = (int)cmdInsertService.ExecuteScalar();
            //    }

            //    // Insert prescription with serviceId as treatment_id
            //    string insertPrescriptionQuery = "INSERT INTO prescription (appointment_id, treatment_id, allergies) VALUES (@appointmentId, @serviceId, @allergies)";
            //    SqlCommand cmdInsertPrescription = new SqlCommand(insertPrescriptionQuery, _sqlconnection);
            //    cmdInsertPrescription.Parameters.AddWithValue("@appointmentId", appointmentId);
            //    cmdInsertPrescription.Parameters.AddWithValue("@serviceId", serviceId);
            //    cmdInsertPrescription.Parameters.AddWithValue("@allergies", AllergiesTxt.Text);

            //    cmdInsertPrescription.ExecuteNonQuery();

            //    _sqlconnection.Close();

            //    LoadPatientTreatmentsToGrid(appointmentId);

            //    Cost.Text = RemoveFirstLine(Cost.Text);

            //    MessageBox.Show("Treatment added successfully");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error" + ex.Message);
            //    _sqlconnection.Close();
            //}
            if (PatientCb.SelectedValue == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No treatments to generate report.");
                return;
            }

            try
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Patient Treatment Report";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
                XFont headerFont = new XFont("Arial", 12, XFontStyle.Bold);
                XFont regularFont = new XFont("Arial", 12, XFontStyle.Regular);

                int margin = 40;
                int yPoint = margin;

                // Title
                gfx.DrawString("Patient Treatment Report", titleFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 30), XStringFormats.TopCenter);
                yPoint += 40;

                // Patient Info
                gfx.DrawString($"Patient Name: {PatientCb.Text}", regularFont, XBrushes.Black, margin, yPoint);
                yPoint += 20;
                gfx.DrawString($"Phone: {PhoneTxt.Text}", regularFont, XBrushes.Black, margin, yPoint);
                yPoint += 20;
                gfx.DrawString($"Gender: {Gender.Text}", regularFont, XBrushes.Black, margin, yPoint);
                yPoint += 20;
                gfx.DrawString($"Allergies: {AllergiesTxt.Text}", regularFont, XBrushes.Black, margin, yPoint);
                yPoint += 30;

                // Table Headers
                gfx.DrawString("Treatment", headerFont, XBrushes.Black, margin, yPoint);
                gfx.DrawString("Cost", headerFont, XBrushes.Black, margin + 350, yPoint);
                yPoint += 20;

                decimal totalCost = 0m;

                // Table rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string treatment = row.Cells["Treatment"].Value?.ToString() ?? "";
                    string costStr = row.Cells["Cost"].Value?.ToString() ?? "0";
                    decimal cost = 0m;
                    decimal.TryParse(costStr, out cost);
                    totalCost += cost;

                    gfx.DrawString(treatment, regularFont, XBrushes.Black, margin, yPoint);
                    gfx.DrawString("₱" + cost.ToString("N2"), regularFont, XBrushes.Black, margin + 350, yPoint);
                    yPoint += 20;

                    // Check if close to bottom of page, add new page
                    if (yPoint > page.Height - margin)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        yPoint = margin;
                    }
                }

                yPoint += 10;
                gfx.DrawString("----------------------------------------------------", regularFont, XBrushes.Black, margin, yPoint);
                yPoint += 20;
                gfx.DrawString($"Total Cost: ₱{totalCost.ToString("N2")}", headerFont, XBrushes.Black, margin, yPoint);

                // Save PDF
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Files|*.pdf", FileName = "TreatmentReport.pdf" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        document.Save(sfd.FileName);
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                        MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }
        private void LoadPatientDetails(int patientId)
        {
            try
            {
                _sqlconnection.Open();

                string patientInfoQuery = @"
                    SELECT TOP 1 
                        a.phone,
                        a.gender,
                        p.allergies
                    FROM appointment a
                    LEFT JOIN prescription p ON a.appointment_id = p.appointment_id
                    WHERE a.appointment_id = @patientId";

                SqlCommand cmdInfo = new SqlCommand(patientInfoQuery, _sqlconnection);
                cmdInfo.Parameters.AddWithValue("@patientId", patientId);

                SqlDataReader drInfo = cmdInfo.ExecuteReader();

                if (drInfo.Read())
                {
                    PhoneTxt.Text = drInfo["phone"]?.ToString() ?? "";
                    Gender.Text = drInfo["gender"]?.ToString() ?? "";
                    AllergiesTxt.Text = drInfo["allergies"]?.ToString() ?? "";
                }
                drInfo.Close();

                string treatmentsQuery = @"
                    SELECT DISTINCT
                        t.description,
                        t.cost
                    FROM prescription p
                    INNER JOIN treatment t ON p.treatment_id = t.treatment_id
                    WHERE p.appointment_id = @patientId";

                SqlCommand cmdTreatments = new SqlCommand(treatmentsQuery, _sqlconnection);
                cmdTreatments.Parameters.AddWithValue("@patientId", patientId);

                SqlDataReader drTreatments = cmdTreatments.ExecuteReader();

                StringBuilder treatments = new StringBuilder();
                StringBuilder costs = new StringBuilder();

                while (drTreatments.Read())
                {
                    treatments.AppendLine(drTreatments["description"].ToString());
                    costs.AppendLine("₱" + Convert.ToDecimal(drTreatments["cost"]).ToString("N2"));
                }

                Cost.Text = costs.ToString().TrimEnd();

                drTreatments.Close();
                _sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                _sqlconnection.Close();
            }
        }


        private void LoadPatientTreatmentsToGrid(int patientId)
        {
            try
            {
                dataGridView1.Rows.Clear();
                _sqlconnection.Open();

                string query = @"
                    SELECT 
                        p.prescription_id,
                        a.name,
                        s.service_name AS description,
                        s.cost
                    FROM prescription p
                    INNER JOIN services s ON p.treatment_id = s.service_id
                    INNER JOIN appointment a ON p.appointment_id = a.appointment_id
                    WHERE p.appointment_id = @patientId
                    ORDER BY s.service_name";

                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                cmd.Parameters.AddWithValue("@patientId", patientId);

                SqlDataReader dr = cmd.ExecuteReader();

                decimal totalCost = 0m;

                while (dr.Read())
                {
                    int prescriptionId = Convert.ToInt32(dr["prescription_id"]);
                    string patientName = dr["name"].ToString();
                    treatmentDesc = dr["description"].ToString();
                    decimal cost = Convert.ToDecimal(dr["cost"]);

                    totalCost += cost;

                    dataGridView1.Rows.Add(prescriptionId, patientName, treatmentDesc, cost.ToString("N2"));
                }

                dr.Close();
                _sqlconnection.Close();

                Cost.Text = "₱" + totalCost.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading treatments into grid: " + ex.Message);
                _sqlconnection.Close();
            }
        }

        private string RemoveFirstLine(string text)
        {
            var lines = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length > 0)
                return string.Join(Environment.NewLine, lines, 1, lines.Length - 1);
            return "";
        }

        private void PatientCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatientCb.SelectedValue != null && int.TryParse(PatientCb.SelectedValue.ToString(), out int patientId))
            {
                LoadPatientDetails(patientId);
                LoadPatientTreatmentsToGrid(patientId);
            }
            else
            {
                Clear();
                dataGridView1.Rows.Clear();
            }
        }
        private void Clear()
        {
            AppService.ClearFields(new List<System.Windows.Forms.TextBox> { PhoneTxt, AllergiesTxt, Cost, Gender });

        }

        private void Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
           ValidationServices.AllowOnlyNumbers(sender, e);
        }
    }
}
