using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helmet_Shot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = helmet2.Image;
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = guna2PictureBox5.Image;
            helmet1.Image = Properties.Resources.helmet1;
            helmet2.Image = Properties.Resources.helmet2;
            helmet3.Image = Properties.Resources.helmet3;
            lblpp.Text = label2.Text;
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = guna2PictureBox6.Image;
            helmet1.Image = Properties.Resources.helmet4;
            helmet2.Image = Properties.Resources.helmet5;
            helmet3.Image = Properties.Resources.helmet6; 
            lblpp.Text = label6.Text;
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = guna2PictureBox7.Image;
            helmet1.Image = Properties.Resources.helmet7;
            helmet2.Image = Properties.Resources.helmet8;
            helmet3.Image = Properties.Resources.helmet9;
            lblpp.Text = label7.Text;
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = guna2PictureBox8.Image;
            helmet1.Image = Properties.Resources.helmet10;
            helmet2.Image = Properties.Resources.helmet11;
            helmet3.Image = Properties.Resources.helmet12;
            lblpp.Text = label10.Text;
        }

        private void helmet1_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = helmet1.Image;
        }

        private void helmet3_Click(object sender, EventArgs e)
        {
            pictureboxshow.Image = helmet3.Image;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
