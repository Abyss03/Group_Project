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
    public partial class List_of_options : Form
    {
        public List_of_options()
        {
            InitializeComponent();
        }


        private void btnHttps_Click(object sender, EventArgs e)
        {
            Https newForm = new Https();
            newForm.Show();
            this.Hide();
        }

        private void Securitycertificate_Click(object sender, EventArgs e)
        {
            Security_certificate newForm = new Security_certificate();
            newForm.Show();
            this.Hide();
        }

        private void btnonlinepayment_Click(object sender, EventArgs e)
        {
            online_payment newForm = new online_payment();
            newForm.Show();
            this.Hide();
        }

        private void btnLogoutSignoff_Click(object sender, EventArgs e)
        {
            Log_out_Sign_off newForm = new Log_out_Sign_off();
            newForm.Show();
            this.Hide();
        }

        private void btnVirtualKeyboard_Click(object sender, EventArgs e)
        {
            Virtual_Keyboard newForm = new Virtual_Keyboard();
            newForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}
