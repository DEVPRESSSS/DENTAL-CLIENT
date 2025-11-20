namespace Dental.Areas.StaffDasboard
{
    partial class StaffLayout
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
            panel1 = new Panel();
            MainContentPanel = new Panel();
            panel2 = new Panel();
            PrescriptionBtn = new Button();
            BillingBtn = new Button();
            AppointmentBtn = new Button();
            LogoutBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(MainContentPanel);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 430);
            panel1.TabIndex = 0;
            // 
            // MainContentPanel
            // 
            MainContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainContentPanel.BackColor = Color.White;
            MainContentPanel.Location = new Point(12, 97);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Size = new Size(889, 321);
            MainContentPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogoutBtn);
            panel2.Controls.Add(PrescriptionBtn);
            panel2.Controls.Add(BillingBtn);
            panel2.Controls.Add(AppointmentBtn);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 75);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // PrescriptionBtn
            // 
            PrescriptionBtn.Anchor = AnchorStyles.None;
            PrescriptionBtn.Cursor = Cursors.Hand;
            PrescriptionBtn.Location = new Point(455, 23);
            PrescriptionBtn.Name = "PrescriptionBtn";
            PrescriptionBtn.Size = new Size(194, 33);
            PrescriptionBtn.TabIndex = 2;
            PrescriptionBtn.Text = "Prescription";
            PrescriptionBtn.UseVisualStyleBackColor = true;
            PrescriptionBtn.Click += PrescriptionBtn_Click;
            // 
            // BillingBtn
            // 
            BillingBtn.Anchor = AnchorStyles.None;
            BillingBtn.Cursor = Cursors.Hand;
            BillingBtn.Location = new Point(241, 23);
            BillingBtn.Name = "BillingBtn";
            BillingBtn.Size = new Size(194, 33);
            BillingBtn.TabIndex = 1;
            BillingBtn.Text = "Billing";
            BillingBtn.UseVisualStyleBackColor = true;
            BillingBtn.Click += BillingBtn_Click;
            // 
            // AppointmentBtn
            // 
            AppointmentBtn.Anchor = AnchorStyles.None;
            AppointmentBtn.Location = new Point(27, 23);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.Size = new Size(194, 33);
            AppointmentBtn.TabIndex = 0;
            AppointmentBtn.Text = "Appointment";
            AppointmentBtn.UseVisualStyleBackColor = true;
            AppointmentBtn.Click += AppointmentBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.None;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Location = new Point(669, 23);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(194, 33);
            LogoutBtn.TabIndex = 3;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // StaffLayout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 430);
            Controls.Add(panel1);
            Name = "StaffLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome staff";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel MainContentPanel;
        private Button PrescriptionBtn;
        private Button BillingBtn;
        private Button AppointmentBtn;
        private Button LogoutBtn;
    }
}