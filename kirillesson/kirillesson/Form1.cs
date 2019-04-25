using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirillesson
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap b;
        Pen pen = new Pen(Color.Red, 5);
        Brush br = new SolidBrush(Color.Green);
        Point p1;
        Point p2;
        private bool moveM;

        public Form1()
        {
            InitializeComponent();
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            //g.FillEllipse(pen.Brush, 100, 100, 50, 50);
        }

        void DrawRec(MouseEventArgs e, Graphics gr) {
            p2 = e.Location;
            gr.DrawRectangle(pen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = e.Location;
            //g.DrawRectangle(pen, p1.X - 25, p1.Y - 25, 50, 50);
            //pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            DrawRec(e, g);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                moveM = true;
                p2 = e.Location;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (moveM) {
                e.Graphics.DrawRectangle(pen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                Refresh();
            }
        }
    }
}
