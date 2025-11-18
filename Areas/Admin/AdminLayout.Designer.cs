namespace Dental.Areas.Admin
{
    partial class AdminLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainContentPanel = new Panel();
            panel2 = new Panel();
            AppointmentBtn = new Button();
            LogoutBtn = new Button();
            BillingBtn = new Button();
            PrescriptionBtn = new Button();
            DashboardBtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainContentPanel
            // 
            MainContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainContentPanel.BackColor = Color.FromArgb(224, 224, 224);
            MainContentPanel.Location = new Point(221, 22);
            MainContentPanel.Margin = new Padding(4, 5, 4, 5);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Size = new Size(1321, 855);
            MainContentPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(AppointmentBtn);
            panel2.Controls.Add(LogoutBtn);
            panel2.Controls.Add(BillingBtn);
            panel2.Controls.Add(PrescriptionBtn);
            panel2.Controls.Add(DashboardBtn);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(11, 22);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 855);
            panel2.TabIndex = 1;
            // 
            // AppointmentBtn
            // 
            AppointmentBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentBtn.ForeColor = Color.Teal;
            AppointmentBtn.Location = new Point(6, 354);
            AppointmentBtn.Margin = new Padding(4, 5, 4, 5);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.Size = new Size(191, 52);
            AppointmentBtn.TabIndex = 7;
            AppointmentBtn.Text = "Appointment";
            AppointmentBtn.UseVisualStyleBackColor = true;
            AppointmentBtn.Click += AppointmentBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogoutBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.Teal;
            LogoutBtn.Location = new Point(6, 798);
            LogoutBtn.Margin = new Padding(4, 5, 4, 5);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(191, 52);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "Log out";
            LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // BillingBtn
            // 
            BillingBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillingBtn.ForeColor = Color.Teal;
            BillingBtn.Location = new Point(6, 292);
            BillingBtn.Margin = new Padding(4, 5, 4, 5);
            BillingBtn.Name = "BillingBtn";
            BillingBtn.Size = new Size(191, 52);
            BillingBtn.TabIndex = 5;
            BillingBtn.Text = "Billing";
            BillingBtn.UseVisualStyleBackColor = true;
            BillingBtn.Click += BillingBtn_Click;
            // 
            // PrescriptionBtn
            // 
            PrescriptionBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrescriptionBtn.ForeColor = Color.Teal;
            PrescriptionBtn.Location = new Point(6, 230);
            PrescriptionBtn.Margin = new Padding(4, 5, 4, 5);
            PrescriptionBtn.Name = "PrescriptionBtn";
            PrescriptionBtn.Size = new Size(191, 52);
            PrescriptionBtn.TabIndex = 4;
            PrescriptionBtn.Text = "Prescription";
            PrescriptionBtn.UseVisualStyleBackColor = true;
            PrescriptionBtn.Click += PrescriptionBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = Color.Teal;
            DashboardBtn.Location = new Point(6, 168);
            DashboardBtn.Margin = new Padding(4, 5, 4, 5);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(191, 52);
            DashboardBtn.TabIndex = 0;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = true;
            // 
            // AdminLayout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1560, 897);
            Controls.Add(panel2);
            Controls.Add(MainContentPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminLayout";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLayout";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainContentPanel;
        private Panel panel2;
        private Button DashboardBtn;
        private Button BillingBtn;
        private Button PrescriptionBtn;
        private Button LogoutBtn;
        private Button AppointmentBtn;
    }
}