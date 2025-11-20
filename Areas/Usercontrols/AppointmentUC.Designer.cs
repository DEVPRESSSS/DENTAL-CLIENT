namespace Dental.Areas.Usercontrols
{
    partial class AppointmentUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label6 = new Label();
            appointmentDate = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            gendercb = new ComboBox();
            label3 = new Label();
            FullnameTxt = new TextBox();
            AddressTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            PhoneTxt = new TextBox();
            panel1 = new Panel();
            ClearBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            AddBtn = new Button();
            AppointmentTbl = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentTbl).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(appointmentDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(gendercb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(FullnameTxt);
            groupBox1.Controls.Add(AddressTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PhoneTxt);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(923, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment details";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(465, 60);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 11;
            label6.Text = "Appointment Date:";
            // 
            // appointmentDate
            // 
            appointmentDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            appointmentDate.Location = new Point(465, 79);
            appointmentDate.Margin = new Padding(2);
            appointmentDate.Name = "appointmentDate";
            appointmentDate.Size = new Size(220, 23);
            appointmentDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(233, 61);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 9;
            label5.Text = "Date of birth:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(236, 79);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(696, 61);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender:";
            // 
            // gendercb
            // 
            gendercb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gendercb.DropDownStyle = ComboBoxStyle.DropDownList;
            gendercb.FormattingEnabled = true;
            gendercb.Items.AddRange(new object[] { "Male", "Female" });
            gendercb.Location = new Point(696, 79);
            gendercb.Margin = new Padding(2);
            gendercb.Name = "gendercb";
            gendercb.Size = new Size(219, 23);
            gendercb.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(236, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Fullname:";
            // 
            // FullnameTxt
            // 
            FullnameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullnameTxt.Location = new Point(236, 35);
            FullnameTxt.Margin = new Padding(2);
            FullnameTxt.MaxLength = 30;
            FullnameTxt.Name = "FullnameTxt";
            FullnameTxt.Size = new Size(220, 23);
            FullnameTxt.TabIndex = 4;
            FullnameTxt.KeyDown += FullnameTxt_KeyDown;
            FullnameTxt.KeyPress += FullnameTxt_KeyPress;
            // 
            // AddressTxt
            // 
            AddressTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddressTxt.Location = new Point(465, 35);
            AddressTxt.Margin = new Padding(2);
            AddressTxt.MaxLength = 45;
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(220, 23);
            AddressTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(465, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(696, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Phone:";
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhoneTxt.Location = new Point(696, 35);
            PhoneTxt.Margin = new Padding(2);
            PhoneTxt.MaxLength = 11;
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(220, 23);
            PhoneTxt.TabIndex = 0;
            PhoneTxt.KeyPress += PhoneTxt_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(UpdateBtn);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(AppointmentTbl);
            panel1.Location = new Point(13, 130);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 358);
            panel1.TabIndex = 1;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearBtn.BackColor = Color.Teal;
            ClearBtn.FlatAppearance.BorderColor = Color.White;
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(584, 326);
            ClearBtn.Margin = new Padding(2);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(78, 23);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.Teal;
            DeleteBtn.FlatAppearance.BorderColor = Color.White;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(666, 326);
            DeleteBtn.Margin = new Padding(2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(78, 23);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateBtn.BackColor = Color.Teal;
            UpdateBtn.FlatAppearance.BorderColor = Color.White;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(749, 326);
            UpdateBtn.Margin = new Padding(2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(78, 23);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatAppearance.BorderColor = Color.White;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(832, 326);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(78, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // AppointmentTbl
            // 
            AppointmentTbl.AllowUserToAddRows = false;
            AppointmentTbl.AllowUserToDeleteRows = false;
            AppointmentTbl.AllowUserToResizeColumns = false;
            AppointmentTbl.AllowUserToResizeRows = false;
            AppointmentTbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AppointmentTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppointmentTbl.BackgroundColor = Color.White;
            AppointmentTbl.BorderStyle = BorderStyle.None;
            AppointmentTbl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            AppointmentTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            AppointmentTbl.DefaultCellStyle = dataGridViewCellStyle1;
            AppointmentTbl.GridColor = Color.Teal;
            AppointmentTbl.Location = new Point(13, 14);
            AppointmentTbl.Margin = new Padding(2);
            AppointmentTbl.Name = "AppointmentTbl";
            AppointmentTbl.ReadOnly = true;
            AppointmentTbl.RowHeadersVisible = false;
            AppointmentTbl.RowHeadersWidth = 62;
            AppointmentTbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentTbl.Size = new Size(897, 310);
            AppointmentTbl.TabIndex = 0;
            AppointmentTbl.CellClick += AppointmentTbl_CellClick;
            // 
            // AppointmentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "AppointmentUC";
            Size = new Size(945, 499);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AppointmentTbl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView AppointmentTbl;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private Label label1;
        private TextBox PhoneTxt;
        private TextBox AddressTxt;
        private Label label2;
        private Label label3;
        private TextBox FullnameTxt;
        private Label label4;
        private ComboBox gendercb;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private DateTimePicker appointmentDate;
    }
}
