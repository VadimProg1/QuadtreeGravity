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
        Quadtree quadtree;
        Random rnd = new Random();
        int winWidth, winHeight, amountOfPoints;
        List<Particle> particles = new List<Particle>();
        bool mouseOnPictureBox = false;
        const int PARTICLES_RADIUS = 6;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            winWidth = 800;
            winHeight = 800;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.Black);
            amountOfPoints = Convert.ToInt32(numeric_amountOfPoints.Value);
            for(int i = 0; i < amountOfPoints; i++)
            {
                particles.Add(new Particle(rnd.Next(0, winWidth), rnd.Next(0, winHeight), winWidth, winHeight, PARTICLES_RADIUS));
            }
            timer1.Start();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            amountOfPoints = Convert.ToInt32(numeric_amountOfPoints.Value);
            particles.Clear();
            for (int i = 0; i < amountOfPoints; i++)
            {
                particles.Add(new Particle(rnd.Next(0, winWidth), rnd.Next(0, winHeight), winWidth, winHeight, PARTICLES_RADIUS));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var particle in particles)
            {
                if (MouseButtons == MouseButtons.Left && mouseOnPictureBox)
                {
                    particle.MoveParticleToCursor();
                }
                else
                {
                    particle.MoveParticle();
                }
            }
            Draw();
        }

        private void Draw()
        {
            graphics.Clear(Color.Black);
            quadtree = new Quadtree(new Rectangle(winWidth / 2,
                winHeight / 2,
                winHeight / 2,
                winWidth / 2),
                4, graphics);
            foreach (var particle in particles)
            {
                quadtree.InsertParticle(particle);
            }
            foreach (var particle in particles)
            {
                List<Particle> list = quadtree.Query(particle, new List<Particle>());
                if (list.Count != 0)
                {
                    graphics.FillEllipse(Brushes.Red, particle.position.X, particle.position.Y, particle.radius * 2, particle.radius * 2);
                }
                else
                {
                    graphics.FillEllipse(Brushes.White, particle.position.X, particle.position.Y, particle.radius * 2, particle.radius * 2);
                }
            }
            quadtree.Draw();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (var particle in particles)
            {
                particle.movingToCursor = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseOnPictureBox = true;
            foreach (var particle in particles)
            {
                particle.SetMouseCoords(e.Location.X, e.Location.Y);
            }
        }
    }
}
