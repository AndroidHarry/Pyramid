using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid
{
    public class Region
    {
        public readonly Point[] points = null;

        //  占几层
        public readonly int LayerCount = 0;


        public Region(Point[] points)
        {
            this.points = points;
            this.LayerCount = CountLayer();
        }

        public static Point[] operator +(Region r, Point pt)
        {
            if (r == null || r.points == null || r.points.Length < 1 ||
                pt == null)
            {
                return null;
            }

            Point[] pts = new Point[r.points.Length];

            for (int i = 0; i < r.points.Length; ++i)
            {
                pts[i] = r.points[i] + pt;
            }

            return pts;
        }

        private int CountLayer()
        {
            if (points == null || points.Length < 1)
            {
                return 0;
            }

            int iMinLayer = points[0].z;
            int iMaxLayer = points[0].z;

            for (int i = 0; i < points.Length; ++i)
            {
                if (points[i].z < iMinLayer)
                {
                    iMinLayer = points[i].z;
                }
                else if (points[i].z > iMaxLayer)
                {
                    iMaxLayer = points[i].z;
                }
            }

            return iMaxLayer - iMinLayer;
        }

        public bool CanFit(Point[] pt)
        {
            if (pt == null || pt.Length < 1 ||
                this.points == null || this.points.Length != pt.Length)
            {
                return false;
            }

            bool bOK = false;
            for (int i = 0; i < points.Length; ++i)
            {
                bOK = false;
                for (int j = 0; j < pt.Length; ++j)
                {
                    if (pt[j].Equal(points[i]))
                    {
                        bOK = true;
                        break;
                    }
                }
                if (!bOK)
                {
                    return false;
                }
            }

            return true;
        }

        public void Print(string title)
        {
            if (points == null)
            {
                Console.WriteLine("region empty.");
                return;
            }

            Console.WriteLine(title);

            for (int i = 0; i < points.Length; ++i)
            {
                Console.WriteLine(
                    string.Format("({0,3},{1,3},{2,3})",
                    points[i].x, points[i].y, points[i].z));
            }
        }

        public void Normalize(bool bZAsc)
        {
            /*
             * 对于立体，定义：
             * 从下到上 z 逐渐变大
             * 从后到前 y 逐渐变大
             * 从左到右 x 逐渐变大
             * 
             * 对于平面，定义：
             * 从上到下 y 逐渐变大
             * 从左到右 x 逐渐变大
             * 
             * 算法的遍历顺序，
             * z 轴，按 bZAsc
             * y 轴，按 从小到大
             * x 轴，按 从小到大
             */

            if (points == null)
                return;

            Point basePoint = new Point(points[0]);

            //  for z
            for (int i = 1; i < points.Length; ++i)
            {
                if (bZAsc)
                {
                    if (points[i].z < basePoint.z)
                    {
                        basePoint.Set(points[i]);
                    }
                }
                else
                {
                    if (points[i].z > basePoint.z)
                    {
                        basePoint.Set(points[i]);
                    }
                }
            }

            //  for x, y
            for (int i = 0; i < points.Length; ++i)
            {
                if (points[i].z == basePoint.z)
                {
                    if (points[i].y < basePoint.y)
                    {
                        basePoint.x = points[i].x;
                        basePoint.y = points[i].y;
                        basePoint.z = points[i].z;
                    }
                    else if (points[i].y == basePoint.y)
                    {
                        if (points[i].x < basePoint.x)
                        {
                            basePoint.x = points[i].x;
                        }
                    }
                }
            }

            //  normalize
            for (int i = 0; i < points.Length; ++i)
            {
                points[i] = points[i] - basePoint;
            }
        }

        private static void TestNormalize()
        {
            Point[] pts = new Point[] {
                //new Point(2, 1, 0),
                //new Point(1, 2, 0),
                //new Point(1, 1, 1),
                //new Point(1, 0, 2),
                //new Point(0, 1, 2)

                new Point(1, 0, 0),
                new Point(0, 1, 0),
                new Point(1, 1, 0),
                new Point(2, 1, 0),
                new Point(1, 2, 0)
            };

            Region r = new Region(pts);
            r.Print("original:");
            r.Normalize(true);
            r.Print("after z asc");
            r.Normalize(false);
            r.Print("after z desc");
        }
    }
}
