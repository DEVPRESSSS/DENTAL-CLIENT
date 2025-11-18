using Dental.Areas.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental.Areas.Admin
{
    public partial class AdminLayout : Form
    {
        public AdminLayout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            Services.AppService.ShowPanel(MainContentPanel, new PrescriptionUC());

        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            Services.AppService.ShowPanel(MainContentPanel, new BillingUC());

        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            Services.AppService.ShowPanel(MainContentPanel, new AppointmentUC());

        }
    }
}
