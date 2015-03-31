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
        string[] questions = new string[]
        {
            "What is 9 cubed?", "What is 6+3?", 
            "What type of animal is tuna sandwiches made from?",
            "What is 18 backwards?"
        };

        string[] answers = new string[] 
        {
        "9", "81", "729", "2", 
        "4", "2", "9", "1", 
        "zebra", "aardvark", "fish", "gnu", 
        "31", "81", "91", "88"
        };
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
