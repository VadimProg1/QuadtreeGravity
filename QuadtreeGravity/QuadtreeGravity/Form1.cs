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
        const int PARTICLES_RADIUS = 4;
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
                particles.Add(new Particle(rnd.Next(0, winWidth),
                        rnd.Next(0, winHeight),
                        winWidth,
                        winHeight,
                        0.01f * (float)numeric_speed.Value,
                        1 + 0.001f * (float)numeric_deceleration.Value,
                        (int)numeric_massOfCursor.Value,
                        PARTICLES_RADIUS
                        ));
            }
            timer1.Start();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            amountOfPoints = Convert.ToInt32(numeric_amountOfPoints.Value);
            particles.Clear();
            for (int i = 0; i < amountOfPoints; i++)
            {
                particles.Add(new Particle(rnd.Next(0, winWidth),
                        rnd.Next(0, winHeight),
                        winWidth,
                        winHeight,
                        0.01f * (float)numeric_speed.Value,
                        1 + 0.001f * (float)numeric_deceleration.Value ,
                        (int)numeric_massOfCursor.Value,
                        PARTICLES_RADIUS
                        ));
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
                if (particle.Collision(quadtree.Query(particle, new List<Particle>())))
                {
                    graphics.FillEllipse(Brushes.Red, particle.position.X, particle.position.Y, particle.radius * 2, particle.radius * 2);
                }
                else
                {
                    graphics.FillEllipse(Brushes.White, particle.position.X, particle.position.Y, particle.radius * 2, particle.radius * 2);
                }
            }
            if (checkBox_quadtree.Checked)
            {
                quadtree.Draw();
            }
            pictureBox1.Refresh();
        }

        private void numeric_amountOfPoints_ValueChanged(object sender, EventArgs e)
        {
            int diff = Math.Abs((int)numeric_amountOfPoints.Value - particles.Count);
            if (numeric_amountOfPoints.Value > particles.Count)
            {
                for (int i = 0; i < diff; i++)
                {
                    particles.Add(new Particle(rnd.Next(0, winWidth),
                        rnd.Next(0, winHeight),
                        winWidth,
                        winHeight,
                        0.01f * (float)numeric_speed.Value,
                        1 + 0.001f * (float)numeric_deceleration.Value,
                        (int)numeric_massOfCursor.Value,
                        PARTICLES_RADIUS
                        ));
                }
            }
            else
            {
                for (int i = 0; i < diff; i++)
                {
                    particles.RemoveAt(particles.Count - 1);
                }
            }
        }

        private void numeric_massOfCursor_ValueChanged(object sender, EventArgs e)
        {
            foreach (var particle in particles)
            {
                particle.decelerationRelativeToDist = (int)numeric_massOfCursor.Value;
            }
        }

        private void numeric_speed_ValueChanged(object sender, EventArgs e)
        {
            foreach (var particle in particles)
            {
                particle.speed = 0.01f * (float)numeric_speed.Value;
            }
        }

        private void numeric_deceleration_ValueChanged(object sender, EventArgs e)
        {
            foreach (var particle in particles)
            {
                particle.deceleration = 1 + 0.001f * (float)numeric_deceleration.Value;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseOnPictureBox = false;
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
