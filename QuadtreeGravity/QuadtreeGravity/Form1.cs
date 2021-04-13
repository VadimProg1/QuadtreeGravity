using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadtreeGravity
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Random rnd = new Random();
        int winWidth, winHeight, amountOfPoints;
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            winWidth = pictureBox1.Width;
            winHeight = pictureBox1.Height;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.Black);
            amountOfPoints = Convert.ToInt32(numeric_amountOfPoints.Value);
            for(int i = 0; i < amountOfPoints; i++)
            {
                points.Add(new Point(rnd.Next(0, winWidth), rnd.Next(0, winHeight)));
            }
            timer1.Start();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            amountOfPoints = Convert.ToInt32(numeric_amountOfPoints.Value);
            points.Clear();
            for (int i = 0; i < amountOfPoints; i++)
            {
                points.Add(new Point(rnd.Next(0, winWidth), rnd.Next(0, winHeight)));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            graphics.Clear(Color.Black);
            foreach (var point in points)
            {
                graphics.FillRectangle(Brushes.White, point.x, point.y, 2f, 2f);
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
