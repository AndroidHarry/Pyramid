using Pyramid.Block;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Ground
{
    /// <summary>
    /// 遍历顺序：
    /// 从上到下 y 逐渐变大
    /// 从左到右 x 逐渐变大
    /// 
    /// </summary>
    public class TriangleGround : IGround
    {
        public int[,] a = new int[10, 10];

        public void Init()
        {
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x < 10; ++x)
                {
                    a[x, y] = (x > y) ? -1 : 0;
                }
            }

            //a[0, 6] = a[0, 7] = a[0, 8] = a[0, 9] = a[1, 8] = 6;
            //a[2, 8] = a[3, 8] = a[1, 9] = a[2, 9] = a[3, 9] = 9;

            //a[0, 9] = a[1, 9] = a[2, 9] = a[3, 9] = a[2, 8] = 6;
            //a[4, 9] = a[5, 9] = a[6, 9] = a[6, 8] = 11;
        }

        public bool CanFill(Point point)
        {
            //  有效的格子
            if (0 <= point.y && point.y < 10 && 0 <= point.x && point.x <= point.y)
            {
                //  未被占用
                return a[point.x, point.y] == 0;
            }

            return false;
        }

        public bool CanFill(Point[] points)
        {
            foreach (Point point in points)
            {
                if (!CanFill(point))
                    return false;
            }

            return true;
        }

        public void Fill(Point[] points, int v)
        {
            foreach (Point point in points)
            {
                a[point.x, point.y] = v;
            }

            // Print();
        }

        public void Print()
        {
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x <= y; ++x)
                {
                    Console.Write(string.Format("{0,3}", a[x, y]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool SuccessFlag()
        {
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x <= y; ++x)
                {
                    if (a[x, y] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 找下一个还没有填充的 point
        /// </summary>
        /// <param name="point">当前 point</param>
        /// <returns></returns>
        private Point NextEmptyPoint(Point point)
        {
            for (int x = point.x; x <= point.y; ++x)
            {
                if (a[x, point.y] == 0)
                {
                    return new Point(x, point.y);
                }
            }

            for (int y = point.y + 1; y < 10; ++y)
            {
                for (int x = 0; x <= y; ++x)
                {
                    if (a[x, y] == 0)
                    {
                        return new Point(x, y);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// 从 blocks 里选取 block 来填充 point 这点，
        /// 遍历顺序：
        /// 从上到下 y 逐渐变大
        /// 从左到右 x 逐渐变大
        /// </summary>
        /// <param name="blocks">可用积木的集合</param>
        /// <param name="point">当前要填充覆盖的点</param>
        /// <returns>是否能正确填完</returns>
        public bool FillBlock(IBlock[] blocks, Point point)
        {
            bool bSuccess = SuccessFlag();
            if (bSuccess)
            {
                return true;
            }

            if (blocks == null)
            {
                return false;
            }

            point = NextEmptyPoint(point);

            for (int b = 0; b < blocks.Length; ++b)
            {
                IBlock block = blocks[b];
                int iShapeCount = block.ShapeCount();

                for (int t = 0; t < iShapeCount; ++t)
                {
                    Point[] points = block.Shape(t, point);
                    if (CanFill(points))
                    {
                        Fill(points, block.Value);

                        bSuccess = SuccessFlag();

                        if (bSuccess)
                        {
                            break;
                        }
                        else
                        {
                            IBlock[] newblocks = blocks.CreateBlocksExcludeIndex(b);

                            if (FillBlock(newblocks, point))
                            {
                                bSuccess = SuccessFlag();

                                if (bSuccess)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                //  erase
                                Fill(points, 0);
                            }
                        }
                    }
                }

                if (bSuccess)
                {
                    break;
                }
                else
                {

                }
            }

            return bSuccess;
        }
    }
}