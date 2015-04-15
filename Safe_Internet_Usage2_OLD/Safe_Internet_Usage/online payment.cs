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
    public partial class online_payment : Form
    {
        public online_payment()
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
