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
        public Graphics g;
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                g.FillEllipse(Brushes.DarkGray, 150, 10, 80, 80);
                g.FillEllipse(Brushes.DarkGray, 150, 100, 80, 80);
                g.FillEllipse(Brushes.DarkGray, 150, 190, 80, 80);
                int fulltime = 6;
                float t = float.Parse(textBox1.Text);
                double sk = t % fulltime;
                if (sk > 0 & sk <= 3)
                { g.FillEllipse(Brushes.Green, 150, 190, 80, 80); }
                else if (sk > 3 & sk <= 4)
                { g.FillEllipse(Brushes.Yellow, 150, 100, 80, 80); }
                else { g.FillEllipse(Brushes.Red, 150, 10, 80, 80); }
                pictureBox1.Invalidate();
            }
            catch
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.Gray, 100, 5, 180, 280);
            g.FillEllipse(Brushes.DarkGray, 150, 10, 80, 80);
            g.FillEllipse(Brushes.DarkGray, 150, 100, 80, 80);
            g.FillEllipse(Brushes.DarkGray, 150, 190, 80, 80);
            g.FillRectangle(Brushes.Black, 180, 285, 25, 90);
            pictureBox1.Image = bmp;
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа светофора для водителей запрограммирована следующим образом: в начале каждого часа в течение трех минут горит зеленый сигнал, затем в течение одной минуты — желтый, в течение двух минут — красный, в течение трех минут — опять зеленый и т. д. Дано вещественное число t, означающее время в минутах, прошедшее с начала очередного часа. Определить, сигнал какого цвета горит для водителей в этот момент.", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBox1.Text) > 60)
                    textBox1.Text = "60";
            }
            catch { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 2 && textBox1.Text.Length <= 2)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
    }
}
