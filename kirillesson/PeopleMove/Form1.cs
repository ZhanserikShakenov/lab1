using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleMove
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Bitmap b2;
        Graphics g2;
        Graphics g;
        Pen pen = new Pen(Color.Black, 3);
        Point left = new Point(200, 20);
        Point right = new Point(250, 20);

        public Form1()
        {
            InitializeComponent();
            b2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g2 = Graphics.FromImage(b2);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox2.Image = b2;
            g.FillRectangle(new SolidBrush(Color.Blue), 0, 0, pictureBox1.Width, pictureBox1.Height / 2);
            g2.FillRectangle(new SolidBrush(Color.Green), 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            DrawHuman(left, g2);
            DrawHuman(right, g2);
        }

        void DrawHuman(Point p, Graphics e) {
            //MessageBox.Show(left + " " + right);
            e.FillEllipse(new SolidBrush(Color.Pink), p.X, p.Y, 30, 30);
            e.DrawLine(pen, p.X + 15, p.Y + 30, p.X + 15, p.Y + 100);
        }

        void MoveHumans(Graphics e) {
            //while (left.X > 0) {
                //e.Clear(Color.Green);
                //MessageBox.Show(left + "" + right);
                DrawHuman(left, e);
                DrawHuman(right, e);
                left.X -= 10;
                right.X += 10;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g2.Clear(Color.Green);
            left.X -= 10;
            right.X += 10;
            //MessageBox.Show(left + " " + right);
            DrawHuman(left, g2);
            DrawHuman(right, g2);
            pictureBox2.Refresh();
        }
    }
}
