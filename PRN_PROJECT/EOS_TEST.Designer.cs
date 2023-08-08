namespace PRN_PROJECT
{
    partial class EOS_TEST
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
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            btnExit1 = new Button();
            btnExit = new Button();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtExamCode = new Label();
            txtDuration = new Label();
            txtQMark = new Label();
            txtStudent = new Label();
            txtTotalMark = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            txtTimer = new Label();
            label8 = new Label();
            numSize = new NumericUpDown();
            cboFont = new ComboBox();
            label9 = new Label();
            btnRealExit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtQuesDesc = new TextBox();
            txtAnsDesc = new TextBox();
            panel = new Panel();
            progressBar = new ProgressBar();
            btnNext = new Button();
            btnBack = new Button();
            label7 = new Label();
            txtTotalQuestion = new Label();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 547);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "I want to finish the exam";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnExit1
            // 
            btnExit1.BackColor = Color.FromArgb(255, 255, 192);
            btnExit1.Enabled = false;
            btnExit1.Location = new Point(12, 572);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(75, 23);
            btnExit1.TabIndex = 1;
            btnExit1.Text = "Finish";
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 255, 192);
            btnExit.Enabled = false;
            btnExit.Location = new Point(599, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Finish";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(437, 12);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(156, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "I want to finish the exam";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 4;
            label1.Text = "Exam Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 5;
            label2.Text = "Duration:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 6;
            label3.Text = "Q Mark:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(168, 99);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 7;
            label4.Text = "Total Marks:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(668, 99);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 8;
            label5.Text = "TimeLeft:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(321, 30);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 9;
            label6.Text = "Student:";
            // 
            // txtExamCode
            // 
            txtExamCode.AutoSize = true;
            txtExamCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtExamCode.ForeColor = Color.FromArgb(0, 0, 192);
            txtExamCode.Location = new Point(108, 30);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Size = new Size(40, 21);
            txtExamCode.TabIndex = 10;
            txtExamCode.Text = "Text";
            // 
            // txtDuration
            // 
            txtDuration.AutoSize = true;
            txtDuration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDuration.ForeColor = Color.FromArgb(0, 0, 192);
            txtDuration.Location = new Point(108, 64);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(40, 21);
            txtDuration.TabIndex = 11;
            txtDuration.Text = "Text";
            // 
            // txtQMark
            // 
            txtQMark.AutoSize = true;
            txtQMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtQMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtQMark.Location = new Point(108, 99);
            txtQMark.Name = "txtQMark";
            txtQMark.Size = new Size(40, 21);
            txtQMark.TabIndex = 12;
            txtQMark.Text = "Text";
            // 
            // txtStudent
            // 
            txtStudent.AutoSize = true;
            txtStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudent.ForeColor = Color.FromArgb(0, 0, 192);
            txtStudent.Location = new Point(395, 30);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(40, 21);
            txtStudent.TabIndex = 13;
            txtStudent.Text = "Text";
            // 
            // txtTotalMark
            // 
            txtTotalMark.AutoSize = true;
            txtTotalMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtTotalMark.Location = new Point(266, 99);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.Size = new Size(40, 21);
            txtTotalMark.TabIndex = 14;
            txtTotalMark.Text = "Text";
            // 
            // txtTimer
            // 
            txtTimer.AutoSize = true;
            txtTimer.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimer.ForeColor = Color.FromArgb(0, 0, 192);
            txtTimer.Location = new Point(747, 64);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(0, 65);
            txtTimer.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(540, 99);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 25;
            label8.Text = "Size:";
            // 
            // numSize
            // 
            numSize.Location = new Point(587, 96);
            numSize.Name = "numSize";
            numSize.Size = new Size(61, 23);
            numSize.TabIndex = 26;
            numSize.ValueChanged += numSize_ValueChanged;
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(368, 96);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(166, 23);
            cboFont.TabIndex = 27;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(321, 99);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 28;
            label9.Text = "Font:";
            // 
            // btnRealExit
            // 
            btnRealExit.Location = new Point(980, 572);
            btnRealExit.Name = "btnRealExit";
            btnRealExit.Size = new Size(75, 23);
            btnRealExit.TabIndex = 29;
            btnRealExit.Text = "Exit";
            btnRealExit.UseVisualStyleBackColor = true;
            // 
            // txtQuesDesc
            // 
            txtQuesDesc.BackColor = Color.White;
            txtQuesDesc.BorderStyle = BorderStyle.FixedSingle;
            txtQuesDesc.Location = new Point(368, 190);
            txtQuesDesc.Multiline = true;
            txtQuesDesc.Name = "txtQuesDesc";
            txtQuesDesc.ReadOnly = true;
            txtQuesDesc.ScrollBars = ScrollBars.Both;
            txtQuesDesc.Size = new Size(646, 336);
            txtQuesDesc.TabIndex = 40;
            // 
            // txtAnsDesc
            // 
            txtAnsDesc.BackColor = Color.White;
            txtAnsDesc.Location = new Point(147, 190);
            txtAnsDesc.Multiline = true;
            txtAnsDesc.Name = "txtAnsDesc";
            txtAnsDesc.ReadOnly = true;
            txtAnsDesc.ScrollBars = ScrollBars.Both;
            txtAnsDesc.Size = new Size(215, 336);
            txtAnsDesc.TabIndex = 39;
            // 
            // panel
            // 
            panel.Location = new Point(32, 228);
            panel.Name = "panel";
            panel.Size = new Size(97, 165);
            panel.TabIndex = 38;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(487, 148);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(527, 34);
            progressBar.TabIndex = 37;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(77, 399);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(55, 23);
            btnNext.TabIndex = 36;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(16, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(55, 23);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(47, 190);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 34;
            label7.Text = "Answer";
            // 
            // txtTotalQuestion
            // 
            txtTotalQuestion.AutoSize = true;
            txtTotalQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalQuestion.ForeColor = Color.FromArgb(0, 0, 192);
            txtTotalQuestion.Location = new Point(47, 155);
            txtTotalQuestion.Name = "txtTotalQuestion";
            txtTotalQuestion.Size = new Size(420, 21);
            txtTotalQuestion.TabIndex = 33;
            txtTotalQuestion.Text = "There are    questions, and your progress of answering is";
            // 
            // EOS_TEST
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 611);
            Controls.Add(txtQuesDesc);
            Controls.Add(txtAnsDesc);
            Controls.Add(panel);
            Controls.Add(progressBar);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(label7);
            Controls.Add(txtTotalQuestion);
            Controls.Add(btnRealExit);
            Controls.Add(label9);
            Controls.Add(cboFont);
            Controls.Add(numSize);
            Controls.Add(label8);
            Controls.Add(txtTimer);
            Controls.Add(txtTotalMark);
            Controls.Add(txtStudent);
            Controls.Add(txtQMark);
            Controls.Add(txtDuration);
            Controls.Add(txtExamCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(checkBox2);
            Controls.Add(btnExit1);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EOS_TEST";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EOS_TEST";
            Load += EOS_TEST_Load;
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button btnExit1;
        private Button btnExit;
        private CheckBox checkBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label txtExamCode;
        private Label txtDuration;
        private Label txtQMark;
        private Label txtStudent;
        private Label txtTotalMark;
        private System.Windows.Forms.Timer Timer;
        private Label txtTimer;
        private Label label8;
        private NumericUpDown numSize;
        private ComboBox cboFont;
        private Label label9;
        private Button btnRealExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtQuesDesc;
        private TextBox txtAnsDesc;
        private Panel panel;
        private ProgressBar progressBar;
        private Button btnNext;
        private Button btnBack;
        private Label label7;
        private Label txtTotalQuestion;
    }
}