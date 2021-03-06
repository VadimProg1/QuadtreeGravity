using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuadtreeGravity
{
    class Quadtree
    {
        Graphics graphics;
        Rectangle boundary;
        List<Particle> points = new List<Particle>();
        Quadtree QTnw, QTne, QTsw, QTse;
        int capacity, winSizeX, winSizeY;
        bool divided = false;
        public Quadtree(Rectangle boundary, int capacity, Graphics graphics)
        {
            this.boundary = boundary;
            this.capacity = capacity;
            this.graphics = graphics;
        }
        public void InsertParticle(Particle p)
        {
            if (!boundary.ContainsPoint(new Point((int)p.position.X, (int)p.position.Y)))
            {
                return;
            }

            if (points.Count < capacity)
            {
                points.Add(p);
            }
            else
            {
                if (!divided)
                {
                    Subdivide();
                    divided = true;
                }
                QTne.InsertParticle(p);
                QTnw.InsertParticle(p);
                QTse.InsertParticle(p);
                QTsw.InsertParticle(p);
            }
        }

        private void Subdivide()
        {
            int x = boundary.x;
            int y = boundary.y;
            int w = boundary.width;
            int h = boundary.height;

            Rectangle nw = new Rectangle(x - w / 2, y - h / 2, h / 2, w / 2);
            Rectangle ne = new Rectangle(x + w / 2, y - h / 2, h / 2, w / 2);
            Rectangle sw = new Rectangle(x - w / 2, y + h / 2, h / 2, w / 2);
            Rectangle se = new Rectangle(x + w / 2, y + h / 2, h / 2, w / 2);
            QTnw = new Quadtree(nw, 4, graphics);
            QTne = new Quadtree(ne, 4, graphics);
            QTsw = new Quadtree(sw, 4, graphics);
            QTse = new Quadtree(se, 4, graphics);
        }

        public void Draw()
        {
            graphics.DrawRectangle(new Pen(Brushes.Green), boundary.x - boundary.width,
                boundary.y - boundary.height, 
                boundary.width * 2, boundary.height * 2);
            if (divided)
            {
                QTne.Draw();
                QTnw.Draw();
                QTse.Draw();
                QTsw.Draw();
            }
        }
    }
}
