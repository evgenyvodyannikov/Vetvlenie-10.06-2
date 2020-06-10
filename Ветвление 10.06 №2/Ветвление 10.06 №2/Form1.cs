using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ветвление_10._06__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.Gray, 100, 0, 180, 280);
            g.FillEllipse(Brushes.Red, 150, 10, 80, 80);
            g.FillEllipse(Brushes.DarkGray, 150, 100, 80, 80);
            g.FillEllipse(Brushes.DarkGray, 150, 190, 80, 80);
            pictureBox1.Image = bmp;
            pictureBox1.Invalidate();
        }
    }
}
