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
    public partial class Log_out_Sign_off : Form
    {
        public Log_out_Sign_off()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            List_of_options newForm = new List_of_options();
            newForm.Show();
            this.Close();
        }
    }
}
