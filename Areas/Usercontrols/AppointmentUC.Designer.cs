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
            groupBox1 = new GroupBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            ClearBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(16, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1319, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment details";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(660, 101);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 9;
            label5.Text = "Date of birth:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(664, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 31);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(994, 101);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Gender:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(994, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(311, 33);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(337, 27);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Fullname:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Location = new Point(337, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(664, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(664, 27);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(994, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 1;
            label1.Text = "Phone:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(994, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 31);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(UpdateBtn);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(18, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 596);
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
            ClearBtn.Location = new Point(834, 547);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(112, 38);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
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
            DeleteBtn.Location = new Point(952, 547);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(112, 38);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
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
            UpdateBtn.Location = new Point(1070, 547);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(112, 38);
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
            AddBtn.Location = new Point(1188, 547);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(112, 38);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1280, 510);
            dataGridView1.TabIndex = 0;
            // 
            // AppointmentUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "AppointmentUC";
            Size = new Size(1350, 832);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}
