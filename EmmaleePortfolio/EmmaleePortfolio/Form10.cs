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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private Random dice = new Random();
        private int boxesLeft = 6;
        private int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int roll = dice.Next(1, 7);
            switch (roll)
            {
                case 1:
                    if (pictureBox1.BackColor == Color.White)
                    {
                        pictureBox1.BackColor = Color.Black;
                        boxesLeft--;
                    }
                    break;
                case 2:
                    if (pictureBox2.BackColor == Color.White)
                    {
                        pictureBox2.BackColor = Color.Black;
                        boxesLeft--;
                    }
                    break;
                case 3:
                    if (pictureBox3.BackColor == Color.White)
                    {
                        pictureBox3.BackColor = Color.Black;
                        boxesLeft--;
                    }
                    break;
                case 4:
                    if (pictureBox4.BackColor == Color.White)
                    {
                        pictureBox4.BackColor = Color.Black;
                        boxesLeft--;
                    }
                    break;
                case 5:
                    if (pictureBox5.BackColor == Color.White)
                    {
                        pictureBox5.BackColor = Color.Black;
                        boxesLeft--;
                    }
                    break;
                case 6:
                    if (pictureBox6.BackColor == Color.White)
                    {
                        pictureBox6.BackColor = Color.Black;
                        boxesLeft--;
                    }
                    break;
            }           
            if (boxesLeft == 1)
            {
                this.Text = boxesLeft.ToString() + "box left";
            }
            else
            {
                this.Text = boxesLeft.ToString() + "boxes left";
            }

            label2.Text = roll.ToString();
            count++;
            label4.Text = count.ToString();
            if (boxesLeft == 0)
            {
                button1.Enabled = false;
                button3.Enabled = true;
                MessageBox.Show("All Boxes Filled");
            }
            }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Text = "6 boxes left";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            boxesLeft = 6;
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White; 
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            label2.Text = "";
            label3.Text = "0";
            button1.Enabled = true;
        }
    }
    
}
