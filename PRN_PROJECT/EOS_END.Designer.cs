namespace PRN_PROJECT
{
    partial class EOS_END
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTimer = new Label();
            txtStudent = new Label();
            txtExamCode = new Label();
            txtMark = new Label();
            dgQuestion = new DataGridView();
            label5 = new Label();
            dgAnswer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAnswer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 99);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Student: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 65);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Time remaining:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 65);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Exam Code:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 136);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Mark:";
            // 
            // txtTimer
            // 
            txtTimer.AutoSize = true;
            txtTimer.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimer.ForeColor = Color.FromArgb(0, 0, 192);
            txtTimer.Location = new Point(307, 25);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(137, 65);
            txtTimer.TabIndex = 16;
            txtTimer.Text = "TEXT";
            // 
            // txtStudent
            // 
            txtStudent.AutoSize = true;
            txtStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudent.ForeColor = Color.FromArgb(0, 0, 192);
            txtStudent.Location = new Point(127, 93);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(40, 21);
            txtStudent.TabIndex = 18;
            txtStudent.Text = "Text";
            // 
            // txtExamCode
            // 
            txtExamCode.AutoSize = true;
            txtExamCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtExamCode.ForeColor = Color.FromArgb(0, 0, 192);
            txtExamCode.Location = new Point(127, 60);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Size = new Size(40, 21);
            txtExamCode.TabIndex = 17;
            txtExamCode.Text = "Text";
            // 
            // txtMark
            // 
            txtMark.AutoSize = true;
            txtMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtMark.Location = new Point(127, 130);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(40, 21);
            txtMark.TabIndex = 19;
            txtMark.Text = "Text";
            txtMark.Click += txtMark_Click;
            // 
            // dgQuestion
            // 
            dgQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgQuestion.Location = new Point(208, 119);
            dgQuestion.Name = "dgQuestion";
            dgQuestion.RowTemplate.Height = 25;
            dgQuestion.Size = new Size(569, 258);
            dgQuestion.TabIndex = 20;
            dgQuestion.CellClick += dgQuestion_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 41;
            label5.Text = "Choosed Answer";
            // 
            // dgAnswer
            // 
            dgAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAnswer.Location = new Point(12, 221);
            dgAnswer.Name = "dgAnswer";
            dgAnswer.RowTemplate.Height = 25;
            dgAnswer.Size = new Size(178, 156);
            dgAnswer.TabIndex = 42;
            // 
            // EOS_END
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(dgAnswer);
            Controls.Add(label5);
            Controls.Add(dgQuestion);
            Controls.Add(txtMark);
            Controls.Add(txtStudent);
            Controls.Add(txtExamCode);
            Controls.Add(txtTimer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EOS_END";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EOS_END";
            FormClosed += EOS_END_FormClosed;
            Load += EOS_END_Load;
            ((System.ComponentModel.ISupportInitialize)dgQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAnswer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txtTimer;
        private Label txtStudent;
        private Label txtExamCode;
        private Label txtMark;
        private DataGridView dgQuestion;
        private Label label5;
        private DataGridView dgAnswer;
    }
}