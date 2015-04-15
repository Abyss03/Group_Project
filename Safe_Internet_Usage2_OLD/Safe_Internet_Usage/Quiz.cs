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
    public partial class frmQuiz : Form
    {
        int score = 0, i = -1, ans = 0;
        
        string getAns()
        {
            if (radA.Checked)
                return radA.Text.ToString();
            if (radB.Checked)
                return radB.Text.ToString();
            if (radC.Checked)
                return radC.Text.ToString();
            if (radD.Checked)
                return radD.Text.ToString();
            return "";
        }
        
        string[] questions = new string[]//Array of questions
        {
            "What is Malware?", "What is Adware?", "What is a computer virus?",
            "What is phishing?"
        };

        string[] answers = new string[] //Array of answers passed to the radio button
        {
        "Sofware Developer", "", "Malicious Software", "", 
        "", "", "", "Malicous pop up advertisments", 
        "", "", "", "A malicious self replicating program", 
        "", "", "Fraudulent Email Scams", ""
        };
        string[] quizAnswers = new string[]//The correct answer compared to the users input
        { "Malicious Software", "Malicous pop up advertisments","A malicious self replicating program","Fraudulent Email Scams"};
        public frmQuiz()
        {
            InitializeComponent();
            //Disable group until the user starts the quiz
            grpAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            lblTag.Visible = false; 
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (i < questions.Length)
            {
                i++;
            }
            try
            {
                lblQues.Text = questions[i];
                radA.Text = answers[ans];
                ans++;
                radB.Text = answers[ans];
                ans++;
                radC.Text = answers[ans];
                ans++;
                radD.Text = answers[ans];
                ans++;
            }
            catch//Allows the user to select to repeat the quiz or exit
            {
                string message = "You have completed the quiz.\nPlay again?";
                string caption = "Congratulations";
                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//Reverts the variables to their initial states
                {
                    grpAnswer.Enabled = false;
                    btnSubmit.Enabled = false;
                    radA.Checked = false; radB.Checked = false; radC.Checked = false; radD.Checked = false;
                    btnPlay.Text = "Play";
                    btnPlay.Enabled = true;
                    lblTag.Visible = false;
                    lblQues.Text = "";
                    int score = 0;
                    i = -1;
                    ans = 0;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }

            grpAnswer.Enabled = true;
            btnPlay.Enabled = false;
            btnSubmit.Enabled = true;
            lblTag.Visible = true;
        }

        //Defines the states of the form elements on click 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (getAns().Equals(quizAnswers[i]))//Matches the selected answer to the correct answer
            {

                MessageBox.Show("Correct", "Well Done!");
                score++;
                lblScr.Text = Convert.ToString(score);
                btnSubmit.Enabled = false;
                btnPlay.Enabled = true;
                radA.Checked = false; radB.Checked = false;
                radC.Checked = false; radD.Checked = false;
                btnPlay.Text = "Next";
            }
            else
            {
                MessageBox.Show("Incorrect", "Try Again");
                score--;
                lblScr.Text = Convert.ToString(score);
                btnSubmit.Enabled = false;
                btnPlay.Enabled = true;
                btnPlay.Text = "Next";
            }
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

        private void btnExitEnter(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.BackColor = Color.Red;
            }
            catch { } //catch invalid exceptions
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
