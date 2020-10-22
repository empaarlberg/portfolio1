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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private Random RDM = new Random();
        private int warning = 0;
        private void Form6_Load(object sender, EventArgs e)
        {
            int divthis = RDM.Next(1, 10);
            label1.Text = divthis.ToString();
            int divwith = RDM.Next(1, 10);
            label3.Text = divwith.ToString();
            int divd = (int)(divthis / divwith);
            label4.Text = divd.ToString();
            int rem = divthis % divwith;
            label5.Text = rem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int divthis = RDM.Next(1, 10);
            label1.Text = divthis.ToString();
            int divwith = RDM.Next(1, 10);
            label3.Text = divwith.ToString();
            int divd = (int)(divthis / divwith);
            label4.Text = divd.ToString();
            int rem = divthis % divwith;
            label5.Text = rem.ToString();
            //funstuff
            warning++;
            if(warning == 100)
            {
                MessageBox.Show("You should take a break");
                button1.Enabled = false;
                button1.Text = "";
            }


        }
    }
}
