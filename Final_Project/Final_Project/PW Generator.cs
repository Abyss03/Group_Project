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
    public partial class PW_Generator : Form
    {
        char[] A = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] a = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] num = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] Aa = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] Anum = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] anum = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] Aanum = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] S = new char[] { '@', '!', '£', '#', '?', '*', '.' };
        char[] sn = new char[] { '@', '!', '£', '#', '?', '*', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] Sl = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '@', '!', '£', '#', '?', '*', '.' };
        char[] SU = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '@', '!', '£', '#', '?', '*', '.' };
        char[] S3 = new char[] { '@', '!', '£', '#', '?', '*', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] S4 = new char[] { '@', '!', '£', '#', '?', '*', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] all = new char[] { '@', '!', '£', '#', '?', '*', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Random rnd = new Random();

        public PW_Generator()
        {
            InitializeComponent();
            button1.Enabled = false;

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Do_Checkbox();
        }


        private void Do_Checkbox()
        {
            string password = "";
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked ==true)
            {
 
                   for (int count = 0; count < numericUpDown1.Value; count++)
                   {
                       password += all[rnd.Next(0, all.Length)];
                   }
                    textBox1.Text = password;
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += Aanum[rnd.Next(0, Aanum.Length)];

                }
                textBox1.Text = password;

            }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)
             {
                 for (int count = 0; count < numericUpDown1.Value; count++)
                 {
                     password += Aa[rnd.Next(0, Aa.Length)];

                 }
                 textBox1.Text = password;

             }

            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked ==true)
            {
                    for (int count = 0; count < numericUpDown1.Value; count++)
                    {
                        password += S3[rnd.Next(0, S3.Length)];

                    }
                    textBox1.Text = password;
                

            }

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += sn[rnd.Next(0, sn.Length)];

                }
                textBox1.Text = password;
            }

            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked ==true)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += S4[rnd.Next(0, S4.Length)];

                }
                textBox1.Text = password;
            }

            if (checkBox1.Checked == true && checkBox3.Checked == true && checkBox2.Checked == false && checkBox4.Checked == false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += Anum[rnd.Next(0, Anum.Length)];

                }
                textBox1.Text = password;
            }

            if (checkBox1.Checked == true && checkBox4.Checked ==true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += SU[rnd.Next(0, SU.Length)];

                }
                textBox1.Text = password;

            }

            if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox1.Checked == false && checkBox4.Checked ==false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += anum[rnd.Next(0, SU.Length)];

                }
                textBox1.Text = password;

            }

            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += A[rnd.Next(0, A.Length)];

                }
                textBox1.Text = password;

            }

            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += a[rnd.Next(0, a.Length)];

                }
                textBox1.Text = password;

            }

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += num[rnd.Next(0, num.Length)];

                }
                textBox1.Text = password;
            }


            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)
            {
                for (int count = 0; count < numericUpDown1.Value; count++)
                {
                    password += S[rnd.Next(0, S.Length)];

                }
                textBox1.Text = password;

            }
            //        else
            //        {
            //            for (int count = 0; count < numericUpDown1.Value; count++)
            //            {
            //                password += Aa[rnd.Next(0, Aa.Length)];
            //            }
            //            textBox1.Text = password;
            //        }
            //    }
            //    else
            //    {
            //        if (checkBox3.Checked == true)
            //        {
            //            for (int count = 0; count < numericUpDown1.Value; count++)
            //            {
            //                password += Anum[rnd.Next(0, Anum.Length)];
            //            }
            //            textBox1.Text = password;
            //        }
            //        else
            //        {
            //            for (int count = 0; count < numericUpDown1.Value; count++)
            //            {
            //                password += A[rnd.Next(0, A.Length)];
            //            }
            //            textBox1.Text = password;
            //        }
            //    }
            //}
            //else
            //{
            //    if (checkBox2.Checked == true)
            //    {
            //        if (checkBox3.Checked == true)
            //        {
            //            for (int count = 0; count < numericUpDown1.Value; count++)
            //            {
            //                password += anum[rnd.Next(0, anum.Length)];
            //            }
            //            textBox1.Text = password;
            //        }
            //        else
            //        {
            //            for (int count = 0; count < numericUpDown1.Value; count++)
            //            {
            //                password += a[rnd.Next(0, a.Length)];
            //            }
            //            textBox1.Text = password;
            //        }
            //    }
            //    else
            //    {
            //        if (checkBox3.Checked == true)
            //        {
            //            for (int count = 0; count < numericUpDown1.Value; count++)
            //            {
            //                password += num[rnd.Next(0, num.Length)];
            //            }
            //            textBox1.Text = password;
            //        }
            //        else
            //        {
            //            textBox1.Text = "Can't generate the a password";
            //        }
                }
            

        

        private void PW_Generator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "")
            {
                numericUpDown1.Text = "0";

                if (  numericUpDown1.Text == "0")
                { button1.Enabled = false;}
            }
            else
            {
                button1.Enabled = true;
            }
            
   
        }

       



    }
}
