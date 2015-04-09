using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordMeter
{
    public partial class Form1 : Form
    {
        public string password;
        public int numberCounter = 0;
        public int uLetterCount = 0;
        public int lLetterCount = 0;
        public int punctuationCounter = 0;
        public string passwordStrength;
        public int characterCount = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            password = textBox1.Text;

            textBox1.Enabled = false;
            textBox2.Enabled = false;

            characterCount = password.Length;
            label5.Text = characterCount.ToString();
            label9.Text = uLetterCount.ToString();
            label10.Text = lLetterCount.ToString();





            foreach (char l in password)
            {

                char myCharacter = l;

                {
                    // Number Counter
                    if (myCharacter == '1' || myCharacter == '2' || myCharacter == '3' || myCharacter == '4' || myCharacter == '5' || myCharacter == '6' || myCharacter == '7' || myCharacter == '8' || myCharacter == '9' || myCharacter == '0')
                    {
                        numberCounter++;
                    }

                    // Upper Case Counter //
                    if (char.IsUpper(myCharacter))
                    {
                        uLetterCount++;
                    }

                    // Lower Case Counter//                                            
                    if (char.IsLower(myCharacter))
                    {
                        lLetterCount++;
                    }

                    // Punctuation Counter 
                    if (myCharacter == '-' || myCharacter == '\'' || myCharacter == '\"' || myCharacter == ':' || myCharacter == ';' || myCharacter == '&' || myCharacter == '(' || myCharacter == ')' || myCharacter == '.')
                    {
                        punctuationCounter++;
                    }

                }


                label5.Text = characterCount.ToString();
                label9.Text = uLetterCount.ToString();
                label10.Text = lLetterCount.ToString();
                label11.Text = punctuationCounter.ToString();
                label15.Text = numberCounter.ToString();

                button1.Enabled = false;


            }

            if (characterCount < 4)
            {
                pictureBox1.Image = Image.FromFile("red.jpg");
                label13.Text = "Your password is too short. To improve security, you may want to add more characters, which can also include: letters, numbers and special characters";
            }
                else
                {

                    if (characterCount >= 4 && characterCount <= 10)
                    {
                        pictureBox1.Image = Image.FromFile("yellow.jpg");

                        if (numberCounter == 0)
                        {
                            label13.Text = "To improve security, you may want to add numbers";
                        }

                        if (punctuationCounter == 0)
                        {
                            label13.Text = "To improve security, you may want to add such special characters such as: -";
                        }

                        if (uLetterCount == 0)
                        {
                            label13.Text = "To improve security, you may want to add capital letters";

                        }

                        else
                        {
                            if (characterCount >=5 && numberCounter >= 1 && punctuationCounter >= 1 && uLetterCount >=1)
                            {
                                pictureBox1.Image = Image.FromFile("green1.jpg");
                                label13.Text = "Your password is strong!";
                            }

                        }
                    }

               
                }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

            this.AcceptButton = button1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
       

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         textBox1.Text = string.Empty;
         textBox2.Text = string.Empty;
         textBox1.Enabled = true;
         textBox2.Enabled = true;
         pictureBox1.Image = null;

         numberCounter = 0;
         uLetterCount = 0;
         lLetterCount = 0;
         punctuationCounter = 0;
         characterCount = 0;

         label5.Text = "0";
         label9.Text = "0";
         label10.Text = "0";
         label11.Text = "0";
         label15.Text = "0";
         label13.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
