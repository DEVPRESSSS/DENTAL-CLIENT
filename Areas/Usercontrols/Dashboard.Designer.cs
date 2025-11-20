namespace Dental.Areas.Usercontrols
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PatientsCount = new Label();
            AppointmentCount = new Label();
            BillingCount = new Label();
            StaffCount = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(15, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 140);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackColor = Color.Teal;
            panel6.Controls.Add(StaffCount);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(686, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 102);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(BillingCount);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(465, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 102);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(AppointmentCount);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(243, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 102);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(PatientsCount);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(19, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 102);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(15, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 383);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 0;
            label1.Text = "Patients";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 16);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 1;
            label2.Text = "Appointments";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 16);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 2;
            label3.Text = "Billing";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 16);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 3;
            label4.Text = "Staff";
            // 
            // PatientsCount
            // 
            PatientsCount.Anchor = AnchorStyles.Top;
            PatientsCount.AutoSize = true;
            PatientsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientsCount.ForeColor = Color.White;
            PatientsCount.Location = new Point(78, 57);
            PatientsCount.Name = "PatientsCount";
            PatientsCount.Size = new Size(18, 20);
            PatientsCount.TabIndex = 1;
            PatientsCount.Text = "0";
            // 
            // AppointmentCount
            // 
            AppointmentCount.Anchor = AnchorStyles.Top;
            AppointmentCount.AutoSize = true;
            AppointmentCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentCount.ForeColor = Color.White;
            AppointmentCount.Location = new Point(99, 57);
            AppointmentCount.Name = "AppointmentCount";
            AppointmentCount.Size = new Size(18, 20);
            AppointmentCount.TabIndex = 2;
            AppointmentCount.Text = "0";
            // 
            // BillingCount
            // 
            BillingCount.Anchor = AnchorStyles.Top;
            BillingCount.AutoSize = true;
            BillingCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillingCount.ForeColor = Color.White;
            BillingCount.Location = new Point(88, 57);
            BillingCount.Name = "BillingCount";
            BillingCount.Size = new Size(18, 20);
            BillingCount.TabIndex = 3;
            BillingCount.Text = "0";
            // 
            // StaffCount
            // 
            StaffCount.Anchor = AnchorStyles.Top;
            StaffCount.AutoSize = true;
            StaffCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StaffCount.ForeColor = Color.White;
            StaffCount.Location = new Point(88, 57);
            StaffCount.Name = "StaffCount";
            StaffCount.Size = new Size(18, 20);
            StaffCount.TabIndex = 4;
            StaffCount.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(939, 560);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label PatientsCount;
        private Label StaffCount;
        private Label BillingCount;
        private Label AppointmentCount;
    }
}
