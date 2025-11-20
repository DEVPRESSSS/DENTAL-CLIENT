namespace Dental.Areas.Usercontrols
{
    partial class Staff
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            MiddleNameTxt = new TextBox();
            FirstnameTxt = new TextBox();
            panel1 = new Panel();
            StaffTable = new DataGridView();
            ClearBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StaffTable).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PasswordTxt);
            groupBox1.Controls.Add(EmailTxt);
            groupBox1.Controls.Add(MiddleNameTxt);
            groupBox1.Controls.Add(FirstnameTxt);
            groupBox1.Location = new Point(13, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal information and Account details";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(694, 66);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(694, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(502, 13);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Middlename:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(309, 13);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Firstname:";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PasswordTxt.Location = new Point(694, 84);
            PasswordTxt.MaxLength = 15;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(219, 23);
            PasswordTxt.TabIndex = 3;
            // 
            // EmailTxt
            // 
            EmailTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailTxt.Location = new Point(694, 31);
            EmailTxt.MaxLength = 40;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(219, 23);
            EmailTxt.TabIndex = 2;
            EmailTxt.KeyDown += EmailTxt_KeyDown;
            EmailTxt.Leave += EmailTxt_Leave;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MiddleNameTxt.Location = new Point(502, 31);
            MiddleNameTxt.MaxLength = 15;
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(185, 23);
            MiddleNameTxt.TabIndex = 1;
            MiddleNameTxt.KeyPress += MiddleNameTxt_KeyPress;
            // 
            // FirstnameTxt
            // 
            FirstnameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FirstnameTxt.Location = new Point(309, 31);
            FirstnameTxt.MaxLength = 20;
            FirstnameTxt.Name = "FirstnameTxt";
            FirstnameTxt.Size = new Size(185, 23);
            FirstnameTxt.TabIndex = 0;
            FirstnameTxt.KeyPress += FirstnameTxt_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(StaffTable);
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(UpdateBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(AddBtn);
            panel1.Location = new Point(18, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 352);
            panel1.TabIndex = 1;
            // 
            // StaffTable
            // 
            StaffTable.AllowUserToAddRows = false;
            StaffTable.AllowUserToDeleteRows = false;
            StaffTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StaffTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StaffTable.BackgroundColor = Color.White;
            StaffTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffTable.GridColor = Color.Teal;
            StaffTable.Location = new Point(5, 12);
            StaffTable.Name = "StaffTable";
            StaffTable.ReadOnly = true;
            StaffTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StaffTable.Size = new Size(901, 296);
            StaffTable.TabIndex = 12;
            StaffTable.CellClick += StaffTable_CellClick;
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
            ClearBtn.Location = new Point(580, 325);
            ClearBtn.Margin = new Padding(2);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(78, 23);
            ClearBtn.TabIndex = 11;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
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
            UpdateBtn.Location = new Point(745, 325);
            UpdateBtn.Margin = new Padding(2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(78, 23);
            UpdateBtn.TabIndex = 9;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
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
            DeleteBtn.Location = new Point(662, 325);
            DeleteBtn.Margin = new Padding(2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(78, 23);
            DeleteBtn.TabIndex = 10;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
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
            AddBtn.Location = new Point(828, 325);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(78, 23);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Staff";
            Size = new Size(945, 499);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StaffTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox PasswordTxt;
        private TextBox EmailTxt;
        private TextBox MiddleNameTxt;
        private TextBox FirstnameTxt;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button ClearBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView StaffTable;
    }
}
