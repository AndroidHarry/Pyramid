using Pyramid.Block;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Ground
{
    /// <summary>
    /// 遍历顺序：
    /// 从下到上 z 逐渐变大
    /// 从后到前 y 逐渐变大
    /// 从左到右 x 逐渐变大
    /// 
    /// </summary>
    public class PyramidGround : IGround
    {
        private int layerNum = 0;

        private bool bZAsc = false;

        private int[,,] a = null;

        public PyramidGround(int layerNum, bool bZAsc)
        {
            this.layerNum = layerNum;
            if (0 < layerNum && layerNum < 6)
            {
                a = new int[layerNum, layerNum, layerNum];
            }

            this.bZAsc = bZAsc;

            startPoint = bZAsc ? new Point(0, 0, 0) : new Point(0, 0, layerNum - 1);
        }

        public override void Init()
        {
            for (int z = 0; z < layerNum; ++z)
            {
                for (int y = 0; y < layerNum; ++y)
                {
                    for (int x = 0; x < layerNum; ++x)
                    {
                        a[x, y, z] = (x < layerNum - z && y < layerNum - z) ? 0 : -1;
                    }
                }
            }
        }

        public override bool CanFill(Point point)
        {
            //  有效的格子
            if (0 <= point.x && point.x < layerNum && point.x < layerNum - point.z &&
                0 <= point.y && point.y < layerNum && point.y < layerNum - point.z &&
                0 <= point.z && point.z < layerNum)
            {
                //  未被占用
                return a[point.x, point.y, point.z] == 0;
            }

            return false;
        }

        public override void Fill(Point[] points, int v)
        {
            foreach (Point point in points)
            {
                a[point.x, point.y, point.z] = v;
            }

            // Print();
        }

        public override void Print()
        {
            Console.WriteLine($"Layer-{layerNum} Pyramid: {successCount}th success, {timer.Spend()}");
            Console.WriteLine();

            for (int z = layerNum - 1; z >= 0; --z)
            {
                Console.WriteLine($"#{z+1}:");

                string s = "";
                for (int k = 0; k < z; k++)
                {
                    s+=" ";
                }

                for (int y = 0; y < layerNum - z; ++y)
                {
                    Console.Write(s);
                    for (int x = 0; x < layerNum - z; ++x)
                    {
                        Console.Write(string.Format("{0,3}", a[x, y, z]));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public override bool SuccessFlag()
        {
            for (int z = 0; z < layerNum; ++z)
            {
                for (int y = 0; y < layerNum - z; ++y)
                {
                    for (int x = 0; x < layerNum - z; ++x)
                    {
                        if (a[x, y, z] == 0)
                        {
                            return false;
                        }
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
            for (int x = point.x; x < layerNum - point.z; ++x)
            {
                if (a[x, point.y, point.z] == 0)
                {
                    return new Point(x, point.y, point.z);
                }
            }

            for (int y = point.y + 1; y < layerNum - point.z; ++y)
            {
                for (int x = 0; x < layerNum - point.z; ++x)
                {
                    if (a[x, y, point.z] == 0)
                    {
                        return new Point(x, y, point.z);
                    }
                }
            }

            if (bZAsc)
            {
                for (int z = point.z + 1; z < layerNum; ++z)
                {
                    for (int y = 0; y < layerNum - z; ++y)
                    {
                        for (int x = 0; x < layerNum - z; ++x)
                        {
                            if (a[x, y, z] == 0)
                            {
                                return new Point(x, y, z);
                            }
                        }
                    }
                }
            }
            else
            {
                for (int z = point.z - 1; z >= 0; --z)
                {
                    for (int y = 0; y < layerNum - z; ++y)
                    {
                        for (int x = 0; x < layerNum - z; ++x)
                        {
                            if (a[x, y, z] == 0)
                            {
                                return new Point(x, y, z);
                            }
                        }
                    }
                }
            }

            // Print();

            return null;
        }

        /// <summary>
        /// 从 blocks 里选取 block 来填充 point 这点，
        /// 遍历顺序：
        /// 从底到顶 z 逐渐变大
        /// 从后到前 y 逐渐变大
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

                //int iShapeAllCount = block.AllShapeCount();

                int iLessLayer = 1;
                if (this.bZAsc)
                {
                    iLessLayer = this.layerNum - point.z;
                }
                else
                {
                    iLessLayer = point.z + 1;
                }
                Region[] r = block.CreateRegion(iLessLayer);
                if (r != null)
                {
                    for (int t = 0; t < r.Length; ++t)
                    {
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
