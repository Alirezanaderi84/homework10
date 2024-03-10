using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
      
         float num1;
         float num2; 
         float result;
         char x;

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(textBox1.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = " ";
                return;
            }
                textBox1.Text = " ";
                x = '+';
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = " ";
                return;
            }
            textBox1.Text=" ";
            x = '-';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = " ";
                return;
            }
            textBox1.Text = " ";
            x = '*';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = " ";
                return;
                
            }
            textBox1.Text=" ";
            x = '/';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = " ";
                return;
               
            }
            textBox1.Text = " ";
            if (x == '+')
                result = num1 + num2;
            else if (x == '-')
                result = num1 - num2;
            else if (x == '*')
                result = num1 * num2;
            else if (x == '/')
            {
                if (num2 != 0)
                    result = num1 / num2;
                else MessageBox.Show("wrong");
            }
            {
                textBox1.Text = result.ToString();
            }
        }
       
    }
}