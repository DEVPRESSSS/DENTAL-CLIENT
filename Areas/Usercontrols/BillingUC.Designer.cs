namespace Dental.Areas.Usercontrols
{
    partial class BillingUC
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
            Gender = new TextBox();
            label5 = new Label();
            AllergiesTxt = new TextBox();
            PatientCb = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Cost = new TextBox();
            PhoneTxt = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            GenerateReceipt = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(Gender);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(AllergiesTxt);
            groupBox1.Controls.Add(PatientCb);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Cost);
            groupBox1.Controls.Add(PhoneTxt);
            groupBox1.Location = new Point(10, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(974, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Billing details";
            // 
            // Gender
            // 
            Gender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Gender.Enabled = false;
            Gender.Location = new Point(738, 31);
            Gender.Name = "Gender";
            Gender.Size = new Size(225, 23);
            Gender.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(516, 63);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Allergies";
            // 
            // AllergiesTxt
            // 
            AllergiesTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AllergiesTxt.Enabled = false;
            AllergiesTxt.Location = new Point(516, 84);
            AllergiesTxt.Name = "AllergiesTxt";
            AllergiesTxt.Size = new Size(214, 23);
            AllergiesTxt.TabIndex = 10;
            // 
            // PatientCb
            // 
            PatientCb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PatientCb.DropDownStyle = ComboBoxStyle.DropDownList;
            PatientCb.FormattingEnabled = true;
            PatientCb.Location = new Point(296, 31);
            PatientCb.Name = "PatientCb";
            PatientCb.Size = new Size(214, 23);
            PatientCb.TabIndex = 9;
            PatientCb.SelectedIndexChanged += PatientCb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(736, 13);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(516, 13);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(296, 13);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "Patient name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(738, 63);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "Cost:";
            // 
            // Cost
            // 
            Cost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cost.Location = new Point(736, 84);
            Cost.MaxLength = 6;
            Cost.Name = "Cost";
            Cost.Size = new Size(225, 23);
            Cost.TabIndex = 4;
            Cost.KeyPress += Cost_KeyPress;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhoneTxt.Enabled = false;
            PhoneTxt.Location = new Point(516, 31);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(214, 23);
            PhoneTxt.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(GenerateReceipt);
            panel1.Location = new Point(10, 132);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 355);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.Teal;
            dataGridView1.Location = new Point(16, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(944, 306);
            dataGridView1.TabIndex = 11;
            // 
            // GenerateReceipt
            // 
            GenerateReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GenerateReceipt.BackColor = Color.Teal;
            GenerateReceipt.FlatAppearance.BorderColor = Color.White;
            GenerateReceipt.FlatAppearance.BorderSize = 0;
            GenerateReceipt.FlatStyle = FlatStyle.Flat;
            GenerateReceipt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReceipt.ForeColor = Color.White;
            GenerateReceipt.Location = new Point(499, 328);
            GenerateReceipt.Margin = new Padding(2);
            GenerateReceipt.Name = "GenerateReceipt";
            GenerateReceipt.Size = new Size(472, 23);
            GenerateReceipt.TabIndex = 10;
            GenerateReceipt.Text = "Print";
            GenerateReceipt.UseVisualStyleBackColor = false;
            GenerateReceipt.Click += GenerateReceipt_Click;
            // 
            // BillingUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "BillingUC";
            Size = new Size(995, 497);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox PhoneTxt;
        private TextBox Cost;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox PatientCb;
        private Button GenerateReceipt;
        private Label label5;
        private TextBox AllergiesTxt;
        private DataGridView dataGridView1;
        private TextBox Gender;
    }
}
