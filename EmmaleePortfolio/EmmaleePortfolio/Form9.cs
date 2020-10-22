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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private Random numb = new Random();

        private void Form9_Load(object sender, EventArgs e)
        {
            int xOne = numb.Next(1, 21);
            int xTwo = numb.Next(1, 21);
            label1.Text = xOne.ToString();
            label2.Text = xTwo.ToString();
            int product = xOne * xTwo;
            label4.Text = product.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xOne = numb.Next(1, 21);
            int xTwo = numb.Next(1, 21);
            label1.Text = xOne.ToString();
            label2.Text = xTwo.ToString();
            int product = xOne * xTwo;
            label4.Text = product.ToString();
        }
    }
}
