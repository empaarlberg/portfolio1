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
    public partial class Form7 : Form
    {
        private Random Rdm = new Random();
        private int count = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            int add1 = Rdm.Next(1, 11);
            int add2 = Rdm.Next(1, 11);
            int sum = add1 + add2;
            label1.Text = add1.ToString();
            label3.Text = add2.ToString();
            label4.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int add1 = Rdm.Next(1, 11);
            int add2 = Rdm.Next(1, 11);
            int sum = add1 + add2;
            label1.Text = add1.ToString();
            label3.Text = add2.ToString();
            label4.Text = sum.ToString();
            count++;
            if(count == 100)
            {
                MessageBox.Show("You should take a break");
                button3.Enabled = false;
                button3.Text = "";
            }
        }
    }
}
