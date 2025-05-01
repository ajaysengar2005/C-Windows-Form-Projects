using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Controlled_WEB
{
    public partial class FormGradeCalculator : Form
    {
        public FormGradeCalculator()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                int s1 = Convert.ToInt32(textBoxSub1.Text);
                int s2 = Convert.ToInt32(textBoxSub2.Text);
                int s3 = Convert.ToInt32(textBoxSub3.Text);
                int s4 = Convert.ToInt32(textBoxSub4.Text);
                int s5 = Convert.ToInt32(textBoxSub5.Text);

                if (s1 < 0 || s1 > 100 || s2 < 0 || s2 > 100 || s3 < 0 || s3 > 100 || s4 < 0 || s4 > 100 || s5 < 0 || s5 > 100)
                {

                    MessageBox.Show("Enter Value between 0 to 100");

                }

                double res = (s1 + s2 + s3 + s4 + s5) / 5.0;

                char grade;
                if(res >= 90)
                {
                    grade = 'A';
                }
                else if(res >= 80)
                {
                    grade = 'B';
                }
                else if(res >= 70)
                {
                    grade = 'C';
                }
                else if(res >= 60)
                {
                    grade = 'D';
                }
                else 
                {
                    grade = 'E';
                }

                labelResult.Text = "Grade : " + grade;
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter numeric values");
            }
        }
    }
}
