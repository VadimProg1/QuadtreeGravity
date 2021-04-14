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
        public float deceleration = 1.02f;
        int winSizeX, winSizeY;
        public bool movingToCursor = false;
        public Particle(int x, int y, int winSizeX, int winSizeY)
        {
            position.X = x;
            position.Y = y;
            this.winSizeX = winSizeX;
            this.winSizeY = winSizeY;
        }
        public void SetMouseCoords(int x, int y)
        {
            mousePos.X = x;
            mousePos.Y = y;
        }

        public void FindVelocity(Vector2 p)
        {
            float vecX = p.X - position.X;
            float vecY = p.Y - position.Y;
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
