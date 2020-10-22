using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmmaleePortfolio
{
    public partial class Form4 : Form
    {
        //Emmalee Paarlberg 9/28/20
        private Random Rdm = new Random();
        private int count = 0; 
        public Form4()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = count.ToString();
            if (button1.Text == "ON")
            {
                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
                button1.Text = "OFF";
                count++;
                if (count == 10 || Rdm.Next(1,11) >=8 )
                {
                    button1.Enabled = false;
                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                    button2.Enabled = true;
                    MessageBox.Show("You blew a fuse.");
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
            button2.Enabled = false;
            this.Text = count.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
