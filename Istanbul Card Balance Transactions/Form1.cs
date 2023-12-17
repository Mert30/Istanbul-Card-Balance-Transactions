using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istanbul_Card_Balance_Transactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double balance = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = balance.ToString() + " TL";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            balance += 10;
            label2.Text = balance.ToString() + " TL";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            balance += 20;
            label2.Text = balance.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balance += 50;
            label2.Text = balance.ToString() + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            balance += 100;
            label2.Text = balance.ToString() + " TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            balance += 200;
            label2.Text = balance.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double payment = 0;

            if (checkBox5.Checked)
            {
                if (checkBox1.Checked)
                {
                    payment = 7.32;
                }
                else if (checkBox2.Checked)
                {
                    payment = 3.21;
                }
                else if (checkBox4.Checked)
                {
                    payment = 3.02;
                }
                else if (checkBox3.Checked)
                {
                    payment = 2.58;
                }
                else if (checkBox6.Checked)
                {
                    payment = 2.58;
                }
            }

            if (checkBox8.Checked)
            {
                if (checkBox1.Checked)
                {
                    payment = 15;
                }
                else if (checkBox2.Checked)
                {
                    payment = 10.75;
                }
                else if (checkBox4.Checked)
                {
                    payment = 8.15;
                }
                else if (checkBox3.Checked)
                {
                    payment = 5.15;
                }
                else if (checkBox6.Checked)
                {
                    payment = 5.15;
                }
            }

            if (checkBox7.Checked)
            {
                if (checkBox1.Checked)
                {
                    payment = 10.74;
                }
                else if (checkBox2.Checked)
                {
                    payment = 6.44;
                }
                else if (checkBox4.Checked)
                {
                    payment = 4.92;
                }
                else if (checkBox3.Checked)
                {
                    payment = 3.21;
                }
                else if (checkBox6.Checked)
                {
                    payment = 3.21;
                }
            }

            if (balance < payment)
            {
                MessageBox.Show("Insufficient Balance !");
            }
            else
            {
                balance -= payment;
            }

            label2.Text = balance.ToString() + " TL";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}