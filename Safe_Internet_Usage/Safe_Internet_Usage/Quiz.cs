﻿using System;
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
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void btnExit(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
