using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmmaLoopWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Emmalee Paarlberg 10/12/20
        //this program takes five random numbers and assigns
        //them to a message box for odds or for evens
        private Random mystery = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int eAccum = 0;
            int oAccum = 0;
            
            for(int count = 0; count <5; count++)
            {
                int num = mystery.Next(1, 10);
                if (num % 2 == 0)
                {
                    eAccum += num;
                }
                else
                {
                    oAccum += num;
                }
                
            }
            MessageBox.Show("Evens sum = " + eAccum.ToString());
            MessageBox.Show("Odds sum = " + oAccum.ToString());

        }

        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 100);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(374, 329);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        private int counter = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "There's nothing else";
            counter++;
            if(counter >= 20)
            {
                label1.Text = "please stop";
                label1.Width = 50;
                label1.Height = 50;
                if (counter >= 40)
                {
                    label1.Text = "ST OP";
                    label1.Width = 30;
                    label1.Height = 30;
                    if (counter == 50)
                    {
                        label1.Enabled = false;
                        label1.Text = "I said there is nothing else!!";
                        label1.Width = 400;
                        label1.Height = 400;
                        label1.Left = 0;
                        label1.Top = 0;
                        label1.BackColor = Color.Black;
                        label1.ForeColor = Color.White;
                        timer1.Enabled = false;
                        
                    }
                    
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = mystery.Next(1,300);
            label1.Top = mystery.Next(1,300);
        }
    }
}
