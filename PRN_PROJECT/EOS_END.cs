using PRN_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_PROJECT
{
    public partial class EOS_END : Form
    {
        public EOS_END()
        {
            InitializeComponent();
        }

        public EOS_END(string text1, string text2, double studentMark, string text3)
        {
            InitializeComponent();
            txtExamCode.Text = text1;
            txtStudent.Text = text2;
            txtMark.Text = studentMark.ToString();
            txtTimer.Text = text3;
        }
        public Exam thisexam = new Exam();
        public EOS_END(string text1, string text2, double studentMark, string text3, Exam exam)
        {
            InitializeComponent();
            txtExamCode.Text = text1;
            txtStudent.Text = text2;
            txtMark.Text = studentMark.ToString();
            txtTimer.Text = text3;
            thisexam = exam;
        }

        private void EOS_END_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtMark_Click(object sender, EventArgs e)
        {

        }

        private void EOS_END_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgQuestion.DataSource = thisexam.ListQuestion;
        }

        private void dgQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgAnswer.DataSource = thisexam.ListQuestion[e.RowIndex].ListAnswer;
        }
    }
}
