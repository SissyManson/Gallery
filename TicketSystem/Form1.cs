using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalSum = 0;

            if(radioButton1.Checked)
            {
                totalSum += 3;
            }
            else if(radioButton2.Checked)
            {
                totalSum += 4;
            }
            else if(radioButton3.Checked)
            {
                totalSum += 5;
            }
            else
            {
                MessageBox.Show("Invalid selection");
            }

            if(textBox1.Text != "")
            {
                int ticketCount = int.Parse(textBox1.Text);

                if(ticketCount > 0)
                {
                    totalSum *= ticketCount;
                    label1.Text = totalSum + "$";
                }
            }            
        }
    }
}
