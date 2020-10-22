using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FibbEmmalee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int limit = Convert.ToInt32(comboBox1.Text);
                int previous = 0;
                int current = 1;
                
                for(counter=0; counter<limit; counter++){

                    listBox1.Items.Add(previous.ToString());
                    current += previous; 
                    previous = current - previous;

                }

            }
            catch
            {
                comboBox1.Text = "invalid entry";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i< 100; i += 1)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
