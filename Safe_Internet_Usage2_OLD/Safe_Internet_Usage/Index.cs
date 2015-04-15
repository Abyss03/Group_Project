using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Internet_Usage
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Antivirus_And_Antimalware antishow = new Antivirus_And_Antimalware();
            antishow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spam_Emails spamshow = new Spam_Emails();
            spamshow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Banking_And_Retail bankshow = new Banking_And_Retail();
            bankshow.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmQuiz quizshow = new frmQuiz();
            quizshow.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Password_Security passwordshow = new Password_Security();
            passwordshow.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Password_Checker checkershow = new Password_Checker();
            checkershow.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            PW_Generator PWgen = new PW_Generator();
            PWgen.Show();
        }

        //Following three methods control the button Enter and Leave events
        private void btnEnter(object sender, EventArgs e)
        {
            try 
            {
                Button b = (Button)sender;
                b.BackColor = Color.Green;
            }
            catch { } //catch invalid exceptions
        }
        private void btnLeave(object sender, EventArgs e)
        {
            try 
            {
                Button b = (Button)sender;
                b.BackColor = Color.White;
            }
            catch { } //catch invalid exceptions
        }

        private void btnExitEnter (object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.BackColor = Color.Red;
            }
            catch { } //catch invalid exceptions

        }
    }
}
