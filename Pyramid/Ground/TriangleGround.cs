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
        private const int _len = 10;

        private int[,] a = new int[_len, _len];

        public override void Init()
        {
            for (int y = 0; y < _len; ++y)
            {
                for (int x = 0; x < _len; ++x)
                {
                    a[x, y] = (x > y) ? -1 : 0;
                }
            }
        }

        public override bool CanFill(Point point)
        {
            //  有效的格子
            if (0 <= point.y && point.y < _len && 0 <= point.x && point.x <= point.y)
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

            Print1();
            Print2();
        }

        private void Print1()
        {
            //  以等腰直角三角形的一条直角边为底

            for (int y = 0; y < _len; ++y)
            {
                for (int x = 0; x <= y; ++x)
                {
                    Console.Write(string.Format("{0,3}", a[x, y]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void Print2()
        {
            //  以等腰直角三角形的斜边为底

            for (int i = 0; i < _len; i++)
            {
                for (int k = 0; k < _len - i; k++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(string.Format("{0,4}", a[i - j, _len - 1 - j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public override bool SuccessFlag()
        {
            for (int y = 0; y < _len; ++y)
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

            for (int y = point.y + 1; y < _len; ++y)
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
        protected override bool FillBlock(Block.IBlock[] blocks, Point point)
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
                Block.IBlock block = blocks[b];
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
                                Block.IBlock[] newblocks = 
                                    blocks.CreateBlocksExcludeIndex(block);

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