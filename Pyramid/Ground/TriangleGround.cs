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
        private int[,] a = new int[10, 10];

        public override void Init()
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

        public override bool CanFill(Point point)
        {
            //  有效的格子
            if (0 <= point.y && point.y < 10 && 0 <= point.x && point.x <= point.y)
            {
                //  未被占用
                return a[point.x, point.y] == 0;
            }

            return false;
        }

        public override void Fill(Point[] points, int v)
        {
            foreach (Point point in points)
            {
                a[point.x, point.y] = v;
            }

            // Print();
        }

        public override void Print()
        {
            Console.WriteLine($"Triangle: {successCount}th success, {timer.Spend()}");
            Console.WriteLine();

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

        public override bool SuccessFlag()
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
        protected override bool FillBlock(Block.Block[] blocks, Point point)
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
                Block.Block block = blocks[b];
                //int iShapeCount = block.ShapeFlatCount();
                Region[] r = block.CreateRegion(1);

                if (r != null)
                {
                    for (int t = 0; t < r.Length; ++t)
                    {
                        //Point[] points = block.MoveShape(t, point);
                        Point[] points = r[t] + point;

                        if (CanFill(points))
                        {
                            Fill(points, block.value);

                            bSuccess = SuccessFlag();

                            if (bSuccess)
                            {
                                timer.End();
                                ++successCount;
                                Print();

                                if (CanContinue())
                                {
                                    timer.Start();
                                    //  erase
                                    Fill(points, 0);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Block.Block[] newblocks = blocks.CreateBlocksExcludeIndex(b);

                                FillBlock(newblocks, point);

                                if (!bContinue)
                                {
                                    break;
                                }

                                //  erase
                                Fill(points, 0);
                            }
                        }
                    }
                }

                if (!bContinue)
                {
                    break;
                }
            }

            return bSuccess;
        }
    }
}