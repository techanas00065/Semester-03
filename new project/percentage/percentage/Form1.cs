using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace percentage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int obtainmarks = int.Parse(textBox1.Text);
            int totalmarks = int.Parse(textBox2.Text);


            double RESULT = (double)obtainmarks / totalmarks * 100;


            string grade;
            if (RESULT >= 90)
                grade = "A";
            else if (RESULT >= 80)
                grade = "B";
            else if (RESULT >= 70)
                grade = "c";
            else if (RESULT >= 60)
                grade = "D";
            else
            {
                grade = "f";
            }


            { MessageBox.Show("The percentage is" + RESULT.ToString()+ "% & grade is " + grade.ToString()); }
        }
    }
}
