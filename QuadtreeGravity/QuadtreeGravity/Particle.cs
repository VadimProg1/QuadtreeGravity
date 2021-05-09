using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadtreeGravity
{
    public class Particle
    {
        public Vector2 velocity = new Vector2(0, 0), position, mousePos;
        public int decelerationRelativeToDist = 100;
        public float speed = 0.3f;
        public int radius;
        public bool isColliding = false;
        public float deceleration = 1.02f;
        int winSizeX, winSizeY;
        public bool movingToCursor = false;
        public Particle(int x, int y, int winSizeX, int winSizeY, int radius)
        {
            position.X = x;
            position.Y = y;
            this.radius = radius;
            this.winSizeX = winSizeX;
            this.winSizeY = winSizeY;
            this.speed = speed;
            this.deceleration = deceleration;
            this.decelerationRelativeToDist = decelerationRelativeToDist;
        }
        public void SetMouseCoords(int x, int y)
        {
            mousePos.X = x;
            mousePos.Y = y;
        }

        public void FindVelocity(Vector2 mouse)
        {
            float vecX = mouse.X - position.X;
            float vecY = mouse.Y - position.Y;
            float dist = (float)Math.Sqrt((vecX * vecX) + (vecY * vecY));
            
            if(dist >= decelerationRelativeToDist)
            {
                velocity.X += (vecX / dist) * ((decelerationRelativeToDist / dist) * speed);
                velocity.Y += (vecY / dist) * ((decelerationRelativeToDist / dist) * speed);
            }
            else
            {
                velocity.X += (vecX / dist) * speed;
                velocity.Y += (vecY / dist) * speed;
            }
        }

        public void MoveParticleToCursor()
        {
            FindVelocity(new Vector2(mousePos.X, mousePos.Y));
            position.X += velocity.X;
            position.Y += velocity.Y;
            velocity.X /= deceleration;
            velocity.Y /= deceleration;
            CheckForWalls();
        }
        public bool IntersectsWithParticle(Particle particle)
        {
            int x1 = (int)position.X;
            int y1 = (int)position.Y;
            int x2 = (int)particle.position.X;
            int y2 = (int)particle.position.Y;
            int distX = Math.Abs(x2 - x1);
            int distY = Math.Abs(y2 - y1);
            return Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2)) < (radius + particle.radius);
        }
        public void CheckForWalls()
        {
            if(position.X <= 0 || position.X >= winSizeX)
            {
                velocity.X = -velocity.X;
            }
            if (position.Y <= 0 || position.Y >= winSizeY)
            {
                velocity.Y = -velocity.Y;
            }
        }
        public void MoveParticle()
        {
            velocity.X /= deceleration;
            velocity.Y /= deceleration;
            position.X += velocity.X;
            position.Y += velocity.Y;
            CheckForWalls();

        }
    }
}
