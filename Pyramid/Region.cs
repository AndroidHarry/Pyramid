﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid
{
    public class Region
    {
        public readonly Point[] points = null;

        public Region(Point[] points)
        {
            this.points = points;
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

        
        //public static int GetSize(int[,] mask)
        //{
        //    if (mask == null)
        //        return 0;

        //    for (int y=0;y<)
        //}

        public static Region CreateRegion(int[,] mask)
        {
            return null;
        }

        public static void Test()
        {
            
        }

        private static void TestCreateRegion()
        {
            int[,] ts = new int[3, 3]
            {
                { 0, 1, 0 },
                { 1,1,1},
                { 0,1,0}
            };
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