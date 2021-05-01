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

        public bool ContainsPoint(Point p)
        {
            return (p.x < x + width && p.x > x - width && p.y < y + height && p.y > y - height);
        }
    }
}
