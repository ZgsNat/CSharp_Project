namespace PRN_PROJECT
{
    partial class EOS_START
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
            label1 = new Label();
            label2 = new Label();
            txtExamCode = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(429, 21);
            label1.TabIndex = 0;
            label1.Text = "You can't take the exam if EOS run under the virtual machine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Exam Code:";
            // 
            // txtExamCode
            // 
            txtExamCode.Location = new Point(102, 36);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Size = new Size(296, 23);
            txtExamCode.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(102, 79);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(296, 23);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(296, 23);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(102, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "FU.EDU.VN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Domain:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(102, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(251, 246);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(12, 216);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 11;
            // 
            // EOS_START
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 322);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtExamCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EOS_START";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EOS LOGIN FORM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtExamCode;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Button btnLogin;
        private Button btnExit;
        private Label label6;
    }
}