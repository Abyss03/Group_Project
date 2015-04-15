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
    public partial class Quiz : Form
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
        
        string[] questions = new string[]//Array of questions passed to the question label
        {
            "What is Malware?", "What is Adware?", "What is a computer virus?",
            "What is Phishing?", "How do you know when a Webpage is secure", "Which of these passwords is the most secure?",
            "Where can you change your security settings? (Windows)","How can you secure your Wireless Internet connections"
        };

        string[] answers = new string[] //Array of answers passed to the radio button
        {
        "Sofware Developer", "Skype", "Malicious Software", "Root Kit", 
        "Advertising", "Expansion Packs", "Corrupt Data", "Malicous Pop-Up Advertisments", 
        "A Worm", "WikiLeaks", "Microwave", "A Malicious Self Replicating Program", 
        "A File Type", "Identity Theft", "Fraudulent Email Scams", "Fishing Website",
        "HTTPS and a Padlock Icon", "A Pop-up Window", "Ask Jeeves Icon", "Incognito Window",
        "password", "P_55worD", "pass_word", "PASSWORD",
        "Control Panel", "Security Centre", "Search", "Internet Explorer",
        "Do not broadcast your network name", "Encrypt the network","Only let known devices connect", "All the above"
        
        };
        string[] quizAnswers = new string[]//The correct answer compared to the users input
        { 
        "Malicious Software", "Malicous Pop-Up Advertisments","A Malicious Self Replicating Program",
        "Fraudulent Email Scams","HTTPS and a Padlock Icon","P_55worD","Security Centre","All the above"
        };
        public Quiz()
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
        private void btnPlay_Click_1(object sender, EventArgs e)
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
        private void btnSubmit_Click_1(object sender, EventArgs e)
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

        private void lblScr_Click(object sender, EventArgs e)
        {

        }

        private void lblTag_Click(object sender, EventArgs e)
        {

        }

        private void grpAnswer_Enter(object sender, EventArgs e)
        {

        }

        private void grpAnswer_Enter_1(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }

     

        
    }
}