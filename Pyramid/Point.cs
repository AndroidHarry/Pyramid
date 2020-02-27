using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid
{
    public class Point
    {
        public int x;
        public int y;
        public int z;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
        }

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(Point p)
        {
            Set(p);
        }

        public void Set(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.z = p.z;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public bool Equal(Point pt)
        {
            if (pt == null)
            {
                return false;
            }

            return (x == pt.x && y == pt.y && z == pt.z);
        }
    }
}
