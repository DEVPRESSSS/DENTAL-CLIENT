namespace Dental.Authentication
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            panel1 = new Panel();
            panel3 = new Panel();
            VerifyEmail = new Button();
            label2 = new Label();
            label1 = new Label();
            CodeTxt = new TextBox();
            EmailTxt = new TextBox();
            SubmitBtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            BackBtn = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(VerifyEmail);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(CodeTxt);
            panel3.Controls.Add(EmailTxt);
            panel3.Controls.Add(SubmitBtn);
            panel3.Location = new Point(364, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 385);
            panel3.TabIndex = 1;
            // 
            // VerifyEmail
            // 
            VerifyEmail.BackColor = Color.Teal;
            VerifyEmail.FlatAppearance.BorderSize = 0;
            VerifyEmail.FlatStyle = FlatStyle.Flat;
            VerifyEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerifyEmail.ForeColor = Color.White;
            VerifyEmail.Location = new Point(65, 167);
            VerifyEmail.Name = "VerifyEmail";
            VerifyEmail.Size = new Size(293, 28);
            VerifyEmail.TabIndex = 5;
            VerifyEmail.Text = "Verify";
            VerifyEmail.UseVisualStyleBackColor = false;
            VerifyEmail.Click += VerifyEmail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 211);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 99);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // CodeTxt
            // 
            CodeTxt.Location = new Point(65, 240);
            CodeTxt.MaxLength = 6;
            CodeTxt.Name = "CodeTxt";
            CodeTxt.Size = new Size(293, 23);
            CodeTxt.TabIndex = 2;
            CodeTxt.TextChanged += CodeTxt_TextChanged;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(65, 127);
            EmailTxt.MaxLength = 40;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(293, 23);
            EmailTxt.TabIndex = 1;
            EmailTxt.KeyDown += EmailTxt_KeyDown;
            EmailTxt.KeyPress += EmailTxt_KeyPress;
            EmailTxt.Leave += EmailTxt_Leave;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.Teal;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(65, 291);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(293, 28);
            SubmitBtn.TabIndex = 0;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(BackBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 420);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(3, 3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button BackBtn;
        private Button SubmitBtn;
        private TextBox CodeTxt;
        private TextBox EmailTxt;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button VerifyEmail;
    }
}