using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadtreeGravity
{
    public class Rectangle
    {
        public int x, y, height, width;
        public Rectangle(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public bool ContainsPoint(int x, int y)
        {
            return x < this.x + width && x >= this.x - width && y <= this.y + height && y >= this.y - height;
        }

        public bool IntersectsWithParticle(Particle p)
        {

            float xDist = Math.Abs(x - p.position.X);
            float yDist = Math.Abs(y - p.position.Y);

            double edges = Math.Pow((xDist - width), 2) + Math.Pow((yDist - height), 2);

            // no intersection
            if (xDist > (p.radius + width) || yDist > (p.radius + height))
                return false;

            // intersection within the circle
            if (xDist <= width || yDist <= height)
                return true;

            // intersection on the edge of the circle
            return edges <= p.radius * p.radius;
        }
    }
}
