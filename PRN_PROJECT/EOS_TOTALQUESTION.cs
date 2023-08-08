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
    public partial class EOS_TOTALQUESTION : Form
    {
        public EOS_TOTALQUESTION()
        {
            InitializeComponent();
        }
        public string examcode = "", username = "";
        public EOS_TOTALQUESTION(string text, string text1)
        {
            InitializeComponent();
            examcode = text;
            username = text1;
        }

        private void EOS_TOTALQUESTION_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nbTotalquestion.Value <= 0)
            {
                MessageBox.Show("Total Question isnt valid!");
                return;
            }
            EOS_TEST f = new EOS_TEST(examcode, username, nbTotalquestion.Value);
            f.Show();
            this.Hide();
        }
    }
}
