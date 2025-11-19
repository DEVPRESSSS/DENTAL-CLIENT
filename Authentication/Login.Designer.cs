namespace Dental
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            ForgotPassword = new LinkLabel();
            MaximizeBtn = new Button();
            MinimizeBtn = new Button();
            LoginBtn = new Button();
            PasswordTxt = new TextBox();
            label2 = new Label();
            EmailTxt = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            CloseBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ForgotPassword);
            panel2.Controls.Add(MaximizeBtn);
            panel2.Controls.Add(MinimizeBtn);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(PasswordTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(EmailTxt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(CloseBtn);
            panel2.Location = new Point(11, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 426);
            panel2.TabIndex = 0;
            // 
            // ForgotPassword
            // 
            ForgotPassword.Anchor = AnchorStyles.None;
            ForgotPassword.AutoSize = true;
            ForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForgotPassword.LinkColor = Color.Teal;
            ForgotPassword.Location = new Point(213, 317);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(96, 15);
            ForgotPassword.TabIndex = 9;
            ForgotPassword.TabStop = true;
            ForgotPassword.Text = "forgot password?";
            ForgotPassword.LinkClicked += ForgotPassword_LinkClicked;
            // 
            // MaximizeBtn
            // 
            MaximizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeBtn.FlatAppearance.BorderColor = Color.White;
            MaximizeBtn.FlatAppearance.BorderSize = 0;
            MaximizeBtn.FlatStyle = FlatStyle.Flat;
            MaximizeBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBtn.ForeColor = Color.Teal;
            MaximizeBtn.Location = new Point(333, 3);
            MaximizeBtn.Name = "MaximizeBtn";
            MaximizeBtn.Size = new Size(44, 30);
            MaximizeBtn.TabIndex = 8;
            MaximizeBtn.Text = "+";
            MaximizeBtn.UseVisualStyleBackColor = true;
            MaximizeBtn.Click += MaximizeBtn_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeBtn.FlatAppearance.BorderColor = Color.White;
            MinimizeBtn.FlatAppearance.BorderSize = 0;
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimizeBtn.ForeColor = Color.Teal;
            MinimizeBtn.Location = new Point(283, 3);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(44, 30);
            MinimizeBtn.TabIndex = 7;
            MinimizeBtn.Text = "-";
            MinimizeBtn.UseVisualStyleBackColor = true;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.BackColor = Color.Teal;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(122, 345);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(189, 33);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "LoginBtn";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Anchor = AnchorStyles.None;
            PasswordTxt.Location = new Point(122, 280);
            PasswordTxt.MaxLength = 15;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PlaceholderText = "Enter your password";
            PasswordTxt.Size = new Size(189, 23);
            PasswordTxt.TabIndex = 5;
            PasswordTxt.KeyDown += PasswordTxt_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(122, 262);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // EmailTxt
            // 
            EmailTxt.Anchor = AnchorStyles.None;
            EmailTxt.Location = new Point(122, 225);
            EmailTxt.MaxLength = 40;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "Enter your email";
            EmailTxt.Size = new Size(189, 23);
            EmailTxt.TabIndex = 3;
            EmailTxt.KeyDown += EmailTxt_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(122, 205);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(155, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 97);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.FlatAppearance.BorderColor = Color.White;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.Teal;
            CloseBtn.Location = new Point(384, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(44, 30);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button CloseBtn;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private TextBox PasswordTxt;
        private Label label2;
        private TextBox EmailTxt;
        private Label label1;
        private Button MinimizeBtn;
        private Button MaximizeBtn;
        private LinkLabel ForgotPassword;
    }
}
