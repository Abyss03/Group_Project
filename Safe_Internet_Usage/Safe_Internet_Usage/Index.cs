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
            Quiz quizshow = new Quiz();
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
    }
}
