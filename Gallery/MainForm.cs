using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class MainForm : Form
    {
        int MIN_COUNT = 1;
        int MAX_COUNT = 6;
        int CurrentImage = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void rbImageOne_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = Gallery.Properties.Resources._1;
        }

        private void rbImageTwo_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = Gallery.Properties.Resources._2;
        }

        private void rbImageThree_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = Gallery.Properties.Resources._3;
        }

        private void rbImageFour_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = Gallery.Properties.Resources._4;
        }

        private void slideShowTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 6);

            RenderImage(number);
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            slideShowTimer.Start();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            slideShowTimer.Stop();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(CurrentImage > MIN_COUNT)
            {
                CurrentImage--;
                RenderImage(CurrentImage);
                btnRight.Enabled = true;
            }

            if(CurrentImage == MIN_COUNT)
            {
                btnLeft.Enabled = false;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(CurrentImage < MAX_COUNT)
            {
                CurrentImage++;
                RenderImage(CurrentImage);
                btnLeft.Enabled = true;
            }

            if(CurrentImage == MAX_COUNT)
            {
                btnRight.Enabled = false;
            }
        }

        private void RenderImage(int number)
        {
            switch (number)
            {
                case 1:
                    pbGallery.Image = Gallery.Properties.Resources._1;
                    break;
                case 2:
                    pbGallery.Image = Gallery.Properties.Resources._2;
                    break;
                case 3:
                    pbGallery.Image = Gallery.Properties.Resources._3;
                    break;
                case 4:
                    pbGallery.Image = Gallery.Properties.Resources._4;
                    break;
                case 5:
                    pbGallery.Image = Gallery.Properties.Resources._5;
                    break;
            }
        }

        private void btnMakeSmalleer_Click(object sender, EventArgs e)
        {
            pbGallery.Width -= 20;
            pbGallery.Height -= 20;
            // pbGallery.Height = pbGallery.Height - 20;
        }

        private void btnMakeBigger_Click(object sender, EventArgs e)
        {
            pbGallery.Width += 20;
            pbGallery.Height += 20;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
