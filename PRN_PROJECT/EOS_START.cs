using Microsoft.Data.SqlClient;
using PRN_PROJECT.Models;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using System.Drawing;

namespace PRN_PROJECT
{
    public partial class EOS_START : Form
    {
        public EOS_START()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        DataProvider dp = new DataProvider();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    /* Caách 1
                    String strSQL = "select * from Users " +
                        "where account='" + txtLog.Text + "' " +
                        "and password='" + txtPas.Text + "'"; 
                    DataTable dt = dp.executeQuery(strSQL);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login success");
                    }
                    else
                    {
                        MessageBox.Show("Login fail");
                    }
                    */
                    string ifwrong = "";
                    String strSQL = "select * from Student " +
                        "where Username COLLATE Latin1_General_CS_AS=@acc " +
                        "and Password COLLATE Latin1_General_CS_AS=@pass";
                    SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@acc",txtUsername.Text),
                    new SqlParameter("@pass",txtPassword.Text),


                };

                    int count = 0;
                    using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
                    {
                        if (dr.Read())
                        {

                            count++;
                            //get name by acoount
                        }
                        else
                        {
                            ifwrong = "Username or password wrong!";
                        }

                    }

                    strSQL = "select * from Exam where ExamCode COLLATE Latin1_General_CS_AS = @exa";
                    parameters = new SqlParameter[] {
                        new SqlParameter("@exa", txtExamCode.Text)
                    };
                    using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
                    {
                        if (dr.Read())
                        {
                            count++;
                        }
                        else
                        {
                            ifwrong = "Invalidated ExamCode!";
                        }
                    }
                    if (count == 2)
                    {
                        String name = GetNameByAccount(txtUsername.Text);
                        String examcode = GetExamCode(txtExamCode.Text);
                        /*MessageBox.Show(examcode);*/
                        //EOS_TEST f = new EOS_TEST(txtExamCode.Text, txtUsername.Text);
                        EOS_TOTALQUESTION fq = new EOS_TOTALQUESTION(txtExamCode.Text, txtUsername.Text);
                        fq.Show();
                        this.Hide();

                    }
                    else
                    {
                        label6.Text = ifwrong;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login false: " + ex.Message);
                }
            }

        }

        private string GetExamCode(string text)
        {
            String strSQL = "select* from Exam " +
                        "where ExamCode=@Exam ";
            SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Exam",txtExamCode.Text)
                };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
            }
            return "";
        }

        private string GetNameByAccount(string text)
        {
            String strSQL = "select* from Student " +
                        "where Username=@acc ";
            SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@acc",txtUsername.Text)
                };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
            }
            return "";
        }
    }
}