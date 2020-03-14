using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonClicker
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
            if(counter % 5 == 0)
            {
                Random rnd = new Random();
                int red = rnd.Next(0, 256);
                int green = rnd.Next(0, 256);
                int blue = rnd.Next(0, 256);

                this.BackColor = Color.FromArgb(red, green, blue);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblCounter.Text = counter.ToString();
            this.BackColor = SystemColors.Control;
        }
    }
}
