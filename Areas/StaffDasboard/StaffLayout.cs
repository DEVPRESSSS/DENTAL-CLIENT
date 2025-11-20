using Dental.Areas.Usercontrols;
using Dental.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental.Areas.StaffDasboard
{
    public partial class StaffLayout : Form
    {
        public StaffLayout()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            Services.AppService.ShowPanel(MainContentPanel, new AppointmentUC());

        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            Services.AppService.ShowPanel(MainContentPanel, new BillingUC());

        }

        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            Services.AppService.ShowPanel(MainContentPanel, new PrescriptionUC());

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                Login._instance.Show();

                this.Close();
            }
        }
    }
}
