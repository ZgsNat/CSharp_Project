using PRN_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Timers.Timer;
namespace PRN_PROJECT
{
    public partial class EOS_TEST : Form
    {

        private double StudentMark = 0;
        public EOS_TEST()
        {
            InitializeComponent();
        }
        String[] Alpha = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "J" };
        public EOS_TEST(string examcode, string username)
        {
            InitializeComponent();
            txtStudent.Text = username;
            txtExamCode.Text = examcode;
            txtQMark.Text = "1";
        }
        public int newtotalquesion;
        public EOS_TEST(string examcode, string username, decimal value)
        {
            InitializeComponent();
            txtStudent.Text = username;
            txtExamCode.Text = examcode;
            txtQMark.Text = "1";
            newtotalquesion = (int)value;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {
                    /*MessageBox.Show("Ăn Điểm");*/
                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;
            countdownTimer.Stop();
            UpdateTimeLabel();
            /*MessageBox.Show(txtTimer.Text);*/
            int totalcorrectquesiton = 0;
            foreach (Question q in exam.ListQuestion)
            {
                if (q.Correct == true)
                {
                    totalcorrectquesiton++;
                }
            }
            StudentMark = totalcorrectquesiton / double.Parse(txtTotalMark.Text) * 10;
            /*MessageBox.Show(StudentMark + "");
            Environment.Exit(0);*/
            //EOS_END eos = new EOS_END(txtExamCode.Text, txtStudent.Text, StudentMark, txtTimer.Text);
            
            EOS_END newoesend = new EOS_END(txtExamCode.Text, txtStudent.Text, StudentMark, txtTimer.Text, exam);
            newoesend.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            btnExit.Enabled = checkBox2.Checked;
            checkBox1.Checked = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnExit1.Enabled = checkBox1.Checked;
            checkBox2.Checked = checkBox1.Checked;
        }

        private void EOS_TEST_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public Exam exam = new Exam();
        DataProvider dp = new DataProvider();
        int curPoint = 0;
        private void LoadData()
        {
            exam.ListQuestion = new List<Question>();
            using (PRN_ASSContext context = new PRN_ASSContext())
            {
                var data = (from e in context.Exams
                            where e.ExamCode.Equals(txtExamCode.Text)
                            select new
                            {
                                ExamCode = e.ExamCode,
                                Duration = e.Duration + " Minutes",
                                TotalQues = e.TotalQues,
                                Examsubject = e.ExamSubject,
                            }).ToList();
                txtExamCode.DataBindings.Clear();
                txtExamCode.DataBindings.Add("Text", data, "ExamCode");
                txtTotalMark.DataBindings.Clear();
                txtTotalMark.DataBindings.Add("Text", data, "TotalQues");
                txtDuration.DataBindings.Clear();
                txtDuration.DataBindings.Add("Text", data, "Duration");
                /*txtExamCode.DataBindings.Clear();
                txtExamCode.DataBindings.Add("Text", data, "Examsubject");*/
            }
            SetTimer(int.Parse(txtDuration.Text.Split(' ')[0]), 0);
            StartTimer();
            txtTotalMark.Text = newtotalquesion.ToString(); 
            txtTotalQuestion.Text = "There are " + txtTotalMark.Text + " questions, and your progress of answering is";

            string strSQL = "select top " + txtTotalMark.Text + " * from Question " +
                "where ExamCode = '" + txtExamCode.Text + "' " +
                "order by NEWID()";
            using (IDataReader dr = dp.executeQuery2(strSQL))
            {
                while (dr.Read())
                {
                    Question question = new Question()
                    {
                        QuestionId = dr.GetInt32(0),
                        ExamCode = dr.GetString(1),
                        QuestionDesc = dr.GetString(2),
                        AnswerDesc = dr.GetString(3),
                        Checked = true,
                        Correct = false,
                        InProgress = false,
                        CurrentPoint = curPoint
                    };
                    exam.ListQuestion.Add(question);
                }
            }
            foreach (Question question in exam.ListQuestion)
            {
                question.ListAnswer = new List<Answer>();
                strSQL = "select * from Answer " +
                    "where QuestionID = " + question.QuestionId + " and " +
                    "ExamCode = '" + question.ExamCode + "'";
                using (IDataReader dr2 = dp.executeQuery2(strSQL))
                {
                    while (dr2.Read())
                    {
                        Answer answer = new Answer()
                        {
                            QuestionId = dr2.GetInt32(0),
                            ExamCode = dr2.GetString(1),
                            Stt = dr2.GetInt32(2),
                            Answers = dr2.GetString(3),
                            Correct = dr2.GetBoolean(4),
                            Checked = false
                        };
                        question.ListAnswer.Add(answer);
                    }
                }
            }
            numSize.Value = (decimal)txtQuesDesc.Font.Size;
            PopulateFontFamilies();
            LoadCheckoutAnswer();
        }

        private void PopulateFontFamilies()
        {
            string currentFontFamily = txtQuesDesc.Font.FontFamily.Name;

            cboFont.Items.Clear();
            FontFamily[] fontFamilies = FontFamily.Families;

            foreach (FontFamily fontFamily in fontFamilies)
            {
                cboFont.Items.Add(fontFamily.Name);
            }
            cboFont.SelectedItem = currentFontFamily;
        }

        private int index = 0;
        /*private int numAnswers = 0;*/
        /*private int numOfCheckboxes = 0;*/
        private int numOfCorrectAnswer = 0;
        private int numOfCheckAnswer = 0;
        private void LoadCheckoutAnswer()
        {
            numOfCheckAnswer = exam.ListQuestion[index].CurrentPoint;
            numOfCorrectAnswer = 0;
            panel.Controls.Clear();
            int count = 0;
            txtAnsDesc.Text = exam.ListQuestion[index].AnswerDesc;
            txtQuesDesc.Text = exam.ListQuestion[index].QuestionDesc + "\n";
            foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
            {
                txtQuesDesc.Text += answer.Answers + "\n";
                if (answer.Correct == true)
                {
                    numOfCorrectAnswer++;
                }
                CheckBox checkbox = new CheckBox();
                checkbox.Text = Alpha[count];
                checkbox.Name = "chk_" + count;
                checkbox.Top = count * 25;
                int panelWidth = panel.Width;
                int checkboxWidth = checkbox.Height;
                int left = (panelWidth - checkboxWidth) / 2;
                checkbox.Left = left;
                checkbox.Checked = answer.Checked;
                checkbox.CheckedChanged += Checkbox_CheckedChanged;
                panel.Controls.Add(checkbox);
                count++;
            }
            /*MessageBox.Show(numOfCorrectAnswer + " so cau tra loi dng");*/
            txtQuesDesc.Text = txtQuesDesc.Text.Replace("\n", Environment.NewLine);

        }

        private void Checkbox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            int indexofAnswer = int.Parse(checkbox.Name.Split('_')[1]);
            exam.ListQuestion[index].ListAnswer[indexofAnswer].Checked = checkbox.Checked;
            if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == true && checkbox.Checked == true)
            {
                numOfCheckAnswer++;
            }
            else
            {
                if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == true && checkbox.Checked == false)
                {
                    numOfCheckAnswer--;
                }
            }
            if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == false && checkbox.Checked == true)
            {
                numOfCheckAnswer--;
            }
            else
            {
                if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == false && checkbox.Checked == false)
                {
                    numOfCheckAnswer++;
                }
            }
            exam.ListQuestion[index].Checked = false;
        }

        private System.Windows.Forms.Timer countdownTimer;
        private int remainingMinutes = 0;
        private int remainingSeconds = 0;

        private void SetTimer(int minutes, int seconds)
        {
            remainingMinutes = minutes;
            remainingSeconds = seconds;
        }

        private void StartTimer()
        {
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick; // Attach the event handler
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Decrement the remaining time
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
            }
            else
            {
                if (remainingMinutes > 0)
                {
                    remainingMinutes--;
                    remainingSeconds = 59;
                }
                else
                {
                    // Countdown finished
                    MessageBox.Show("Countdown finished!");
                    if (exam.ListQuestion[index].Checked == false)
                    {
                        if (numOfCheckAnswer == numOfCorrectAnswer)
                        {
                            /*MessageBox.Show("Ăn Điểm");*/
                            exam.ListQuestion[index].Correct = true;
                        }
                        else
                        {
                            exam.ListQuestion[index].Correct = false;
                        }
                        exam.ListQuestion[index].Checked = true;
                    }
                    curPoint = numOfCheckAnswer;
                    exam.ListQuestion[index].CurrentPoint = curPoint;
                    UpdateTimeLabel();
                    /*MessageBox.Show(txtTimer.Text);*/
                    int totalcorrectquesiton = 0;
                    foreach (Question q in exam.ListQuestion)
                    {
                        if (q.Correct == true)
                        {
                            totalcorrectquesiton++;
                        }
                    }
                    StudentMark = totalcorrectquesiton / double.Parse(txtTotalMark.Text) * 10;
                    /*MessageBox.Show(StudentMark + "");
                    Environment.Exit(0);*/
                    EOS_END eos = new EOS_END(txtExamCode.Text, txtStudent.Text, StudentMark, txtTimer.Text);
                    eos.Show();
                    this.Hide();
                    return;
                }
            }

            // Update the label
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            // Format the remaining time as "mm:ss"
            string formattedTime = $"{remainingMinutes:D2}:{remainingSeconds:D2}";
            txtTimer.Text = formattedTime;
        }
        private int totalAnswered = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (totalAnswered < 0)
                {
                    totalAnswered = 0;
                }
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {
                    /*MessageBox.Show("Ăn Điểm");*/
                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }
                int totalCheckedAnswer = 0;
                foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
                {
                    if (answer.Checked == true)
                    {
                        totalCheckedAnswer++;
                    }
                }
                if (totalCheckedAnswer != 0)
                {
                    exam.ListQuestion[index].InProgress = true;
                }
                else
                {
                    exam.ListQuestion[index].InProgress = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;

            index++;

            if (index == Int32.Parse(txtTotalMark.Text))
            {
                index = 0;
            }
            LoadCheckoutAnswer();
            foreach (Question question in exam.ListQuestion)
            {
                if (question.InProgress == true)
                {
                    totalAnswered++;
                }
            }
            UpdateProgressBar(totalAnswered, int.Parse(txtTotalMark.Text));
            totalAnswered = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (totalAnswered < 0)
                {
                    totalAnswered = 0;
                }
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {
                    /*MessageBox.Show("Ăn Điểm");*/
                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }

                /*if (numOfCheckAnswer != 0)
                {
                    totalAnswered++;
                    if (totalAnswered > int.Parse(txtTotalMark.Text))
                    {
                        totalAnswered = int.Parse(txtTotalMark.Text);
                    }
                }
                else
                {
                    totalAnswered--;
                    if (totalAnswered < 0)
                    {
                        totalAnswered = 0;
                    }
                }*/
                int totalCheckedAnswer = 0;
                foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
                {
                    if (answer.Checked == true)
                    {
                        totalCheckedAnswer++;
                    }
                }
                if (totalCheckedAnswer != 0)
                {
                    exam.ListQuestion[index].InProgress = true;
                }
                else
                {
                    exam.ListQuestion[index].InProgress = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;
            index--;
            if (index < 0)
            {
                index = Int32.Parse(txtTotalMark.Text) - 1;
            }
            LoadCheckoutAnswer();
            foreach (Question question in exam.ListQuestion)
            {
                if (question.InProgress == true)
                {
                    totalAnswered++;
                }
            }
            UpdateProgressBar(totalAnswered, int.Parse(txtTotalMark.Text));
            totalAnswered = 0;
        }

        private void UpdateProgressBar(int answeredQuestions, int totalQuestions)
        {
            int progressPercentage = (int)((double)answeredQuestions / totalQuestions * 100);
            progressBar.Value = progressPercentage;
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            float fontSize = (float)numSize.Value;
            Font currentFont = txtQuesDesc.Font;
            Font newFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            txtQuesDesc.Font = newFont;
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontFamily = cboFont.SelectedItem.ToString();

            FontFamily fontFamily = new FontFamily(selectedFontFamily);
            Font newFont = new Font(fontFamily, txtQuesDesc.Font.Size, txtQuesDesc.Font.Style);

            txtQuesDesc.Font = newFont;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQuesDesc_SizeChanged(object sender, EventArgs e)
        {
            txtQuesDesc.Width = this.Width - txtQuesDesc.Left - 20;
        }
    }
}
