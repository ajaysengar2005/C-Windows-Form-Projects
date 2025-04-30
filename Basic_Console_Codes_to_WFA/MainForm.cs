using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Console_Codes_to_WFA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            FormGradeCalculator formGradeCalculator = new FormGradeCalculator();
            formGradeCalculator.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLeapYear formLeapYear = new FormLeapYear();
            formLeapYear.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYear formYear = new FormYear();
            formYear.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormFact formfact = new FormFact();
            formfact.ShowDialog();
        }
    }
}
