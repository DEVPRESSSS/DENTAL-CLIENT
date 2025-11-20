namespace Dental.Authentication
{
    partial class ChangePassword
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
            SubmitBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ConfirmPassTxt = new TextBox();
            NewPassTxt = new TextBox();
            CloseBtn = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(SubmitBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ConfirmPassTxt);
            panel1.Controls.Add(NewPassTxt);
            panel1.Controls.Add(CloseBtn);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 424);
            panel1.TabIndex = 0;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.Teal;
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(277, 297);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(219, 28);
            SubmitBtn.TabIndex = 5;
            SubmitBtn.Text = "Change";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 206);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 4;
            label2.Text = "Confirm password:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 132);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "New password:";
            // 
            // ConfirmPassTxt
            // 
            ConfirmPassTxt.Location = new Point(278, 234);
            ConfirmPassTxt.MaxLength = 8;
            ConfirmPassTxt.Name = "ConfirmPassTxt";
            ConfirmPassTxt.Size = new Size(219, 23);
            ConfirmPassTxt.TabIndex = 2;
            ConfirmPassTxt.UseSystemPasswordChar = true;
            // 
            // NewPassTxt
            // 
            NewPassTxt.Location = new Point(276, 159);
            NewPassTxt.MaxLength = 8;
            NewPassTxt.Name = "NewPassTxt";
            NewPassTxt.Size = new Size(219, 23);
            NewPassTxt.TabIndex = 1;
            NewPassTxt.UseSystemPasswordChar = true;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(12, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(64, 23);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Back";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(388, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CloseBtn;
        private Label label2;
        private Label label1;
        private TextBox ConfirmPassTxt;
        private TextBox NewPassTxt;
        private Button SubmitBtn;
        private CheckBox checkBox1;
    }
}