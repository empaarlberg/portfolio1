using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmmaleePortfolio
{
    public partial class Form4 : Form
    {
        private Random Rdm = new Random();
        private int count = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ON")
            {
                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
                button1.Text = "OFF";
                count++;
                if (count == 10)
                {
                    button1.Enabled = false;
                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                }
                else if (Rdm.Next(1,11) >= 7)
                {
                    button1.Enabled = false;
                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                }


            }
            else
            {
                pictureBox1.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
                button1.Text = "ON";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            button1.Enabled = true;
            button1.Text = "ON";
        }
    }
}
