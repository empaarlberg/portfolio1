using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testtester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 0;
        private int evenAccum = 0;
        private int oddAccum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            counter++;
            switch (counter)
            {
                case 1:
                    button1.Text = "High";
                    break;
                case 2:
                    button1.Text = "Medium";
                    break;
                case 3:
                    button1.Text = "Low";
                    break;
            }
            if (counter == 3)
            {
                counter = 0;
            }
            int num1 = Convert.ToInt32(textBox1.Text);
           
            if (num1 % 2 == 0 )
            {
                evenAccum = num1 + evenAccum;
            }
            else
            {
                oddAccum = oddAccum + num1;
            }
            this.Text = evenAccum.ToString() +"or" + oddAccum.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = 1.1;
                double z = num1 + num2;
                if (z > 5.0)
                {
                    MessageBox.Show("z");
                }

            

        }
    }
}
