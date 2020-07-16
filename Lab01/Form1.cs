using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        preProcessing process = new preProcessing();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process.loadOriginalImage();
            pictureBox1.ImageLocation = "1.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.grayScaleImage();
            pictureBox2.ImageLocation = "2.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Height: " + process.extractImageHeight(Height) + ",  Width: " + process.extractImageWight(Width) + ", Channels: " + process.extractImageChannels(Height));
        }
    }
}
