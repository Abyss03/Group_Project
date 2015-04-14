using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordStrengthChecker PasswordStrengthCheckerForm = new PasswordStrengthChecker();
            PasswordStrengthCheckerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AntivirusMalware AntivirusMalwareForm = new AntivirusMalware();
            AntivirusMalwareForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quiz QuizForm = new Quiz();
            QuizForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PW_Generator PasswordGenerator = new PW_Generator();
            PasswordGenerator.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Spam_Emails spamEmailForm = new Spam_Emails();
            spamEmailForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Online onlineForm = new Online();
            onlineForm.Show();
        }
    }
}
