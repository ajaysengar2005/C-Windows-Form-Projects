using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOB_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerCurrent.Value < dateTimePickerDOB.Value)
                {
                    MessageBox.Show("Current age should be greater !");
                }
                int age = dateTimePickerCurrent.Value.Year - dateTimePickerDOB.Value.Year;
                label3.Visible = true;
                label3.Text = "Your current age : "+age.ToString();

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
