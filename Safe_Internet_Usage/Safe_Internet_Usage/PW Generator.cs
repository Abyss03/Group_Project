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
    public partial class PW_Generator : Form
    {

        char[] A = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        char[] a = new char[]{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] num = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] Aa = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' ,'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] Anum = new char[]{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        char[] anum = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] Aanum = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        Random rnd = new Random();

        public PW_Generator()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Do_Checkbox();
        }


        private void Do_Checkbox()
        {
            string password = "";
            if(checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox3.Checked == true)
                    {
                        for (int count = 0; count < numericUpDown1.Value; count++)
                        {
                            password += Aanum[rnd.Next(0, Aanum.Length)];
                        }
                        textBox1.Text = password;
                    }
                    else
                    {
                        for (int count = 0; count < numericUpDown1.Value; count++)
                        {
                            password += Aa[rnd.Next(0, Aa.Length)];
                        }
                        textBox1.Text = password;
                    }
                }
                else
                {
                    if (checkBox3.Checked == true)
                    {
                        for (int count = 0; count < numericUpDown1.Value; count++)
                        {
                            password += Anum[rnd.Next(0, Anum.Length)];
                        }
                        textBox1.Text = password;
                    }
                    else
                    {
                        for (int count = 0; count < numericUpDown1.Value; count++)
                        {
                            password += A[rnd.Next(0, A.Length)];
                        }
                        textBox1.Text = password;
                    }
                }
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox3.Checked == true)
                    {
                        for (int count = 0; count < numericUpDown1.Value; count++)
                        {
                            password += anum[rnd.Next(0, anum.Length)];
                        }
                        textBox1.Text = password;
                    }
                    else
                    {
                        for (int count = 0; count < numericUpDown1.Value; count++)
                        {
                            password += a[rnd.Next(0, a.Length)];
                        }
                        textBox1.Text = password;
                    }
                }
                else
                {
                    if(checkBox3.Checked == true)
                    {
                    for (int count = 0; count < numericUpDown1.Value; count++)
                    {
                        password += num[rnd.Next(0, num.Length)];
                    }
                    textBox1.Text = password;
                    }
                    else
                    {
                        textBox1.Text = "Can't generate the PW";
                    }
                }
            }

        }

        private void PW_Generator_Load(object sender, EventArgs e)
        {

        }



    }
}
