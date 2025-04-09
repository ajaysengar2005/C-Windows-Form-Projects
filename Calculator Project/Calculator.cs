using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 + num2;
                label3.Text = "Addtion is : "+result.ToString();
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter fields !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 - num2;
                label3.Text = "Subtraction is : " + result.ToString();
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter fields !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 * num2;
                label3.Text = "Multiplication is : " + result.ToString();
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter fields !!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                if(num2 != 0) {
                    double result = num1 / num2;
                    label3.Text = "Division is : " + result.ToString();
                    label3.Visible = true;
                }
                else{
                    MessageBox.Show("Can not divisible !");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter fields !!");
            }
        }
    }
}
