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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private Random roll = new Random();
        private int count = 6;
        private int that;
        private int amount = 0;

        private void Form8_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label2.Text = "?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Location == pictureBox1.Location && pictureBox1.BackColor == Color.White)
            {
                pictureBox1.BackColor = Color.SeaGreen;
                count--;
            }
            else if (pictureBox7.Location == pictureBox2.Location && pictureBox2.BackColor == Color.White)
            {
                pictureBox2.BackColor = Color.SeaGreen;
                count--;
            }
            else if (pictureBox7.Location == pictureBox3.Location && pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackColor = Color.SeaGreen;
                count--;
            }
            else if (pictureBox7.Location == pictureBox4.Location && pictureBox4.BackColor == Color.White)
            {
                pictureBox4.BackColor = Color.SeaGreen;
                count--;
            }
            else if (pictureBox7.Location == pictureBox5.Location && pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackColor = Color.SeaGreen;
                count--;
            }
            else if (pictureBox7.Location == pictureBox6.Location && pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackColor = Color.SeaGreen;
                count--;
            }



            button1.Enabled = true;
            button2.Enabled = false;
            label2.Text = "?";
            this.Text = count.ToString() + "boxes left";

            if (pictureBox1.BackColor == Color.SeaGreen && pictureBox2.BackColor == Color.SeaGreen &&
              pictureBox3.BackColor == Color.SeaGreen && pictureBox4.BackColor == Color.SeaGreen &&
              pictureBox5.BackColor == Color.SeaGreen && pictureBox6.BackColor == Color.SeaGreen)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                label2.Text = "";
                pictureBox7.Left = -50;
                MessageBox.Show("All boxes filled");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            count = 6;
            this.Text = count.ToString() + "boxes left";
            label2.Text = "?";
            pictureBox7.Left = -50;
            button1.Enabled = true;
            button2.Enabled = true;
            amount = 0;
            label4.Text = amount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            that = roll.Next(1, 7);
            button1.Enabled = false;
            button2.Enabled = true;
            label2.Text = that.ToString();
            amount++;
            label4.Text = amount.ToString();
            pictureBox7.Left += that * 100;

            if (pictureBox7.Left >= 650)
            {
                pictureBox7.Left = pictureBox7.Left - 600;
            }
        }
    }
    


}
