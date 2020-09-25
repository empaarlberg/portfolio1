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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 nextForm = new Form4();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 nextForm = new Form5();
            nextForm.Show();
        }
    }
}
