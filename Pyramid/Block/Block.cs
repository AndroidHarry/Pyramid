using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public abstract class Block
    {
        public Block(int v, int[,] mask)
        {
            value = v;

            this.mask = mask;

            int a = mask.GetLength(0);
            int b = mask.GetLength(1);

            unitNum = 0;

            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    if (mask[i,j] == 1)
                    {
                        ++unitNum;
                    }
                }
            }

            int[][,] masks = CreateMasks(mask);

            Region = CreateRegion(masks);
        }
        
        protected readonly int[,] mask;

        private Point[][] CreateRegion(int[][,] masks)
        {
            int a = masks.Length;

            Point[][] pts = new Point[a * 3][];

            for (int k = 0; k < a; ++k)
            {
                pts[k] = new Point[unitNum];
                pts[k + a] = new Point[unitNum];
                pts[k + a + a] = new Point[unitNum];

                int t = 0;
                for (int i = 0; i < masks[k].GetLength(0); ++i)
                {
                    for (int j = 0; j < masks[k].GetLength(1); ++j)
                    {
                        if (masks[k][i, j] == 1)
                        {
                            pts[k][t] = new Point(i, j);
                            pts[k + a][t] = new Point(j, j, -i - j);
                            pts[k + a + a][t] = new Point(j, i, -i - j);

                            ++t;
                        }
                    }
                }
            }

            return pts;
        }

        private Point[][] CreateRegionFlat(int[][,] masks)
        {
            int a = masks.Length;

            Point[][] pts = new Point[a][];

            for (int k = 0; k < a; ++k)
            {
                pts[k] = new Point[unitNum];

                int t = 0;
                for (int i = 0; i < masks[k].GetLength(0); ++i)
                {
                    for (int j = 0; j < masks[k].GetLength(1); ++j)
                    {
                        if (masks[k][i, j] == 1)
                        {
                            pts[k][t++] = new Point(i, j);
                        }
                    }
                }
            }

            return pts;
        }

        private int[][,] CheckCreateMirrorXYMasks(int[,] mask)
        {
            int a = mask.GetLength(0);
            int b = mask.GetLength(1);

            bool bZeroFlag = false;

            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    if (mask[i, j] == 0)
                    {
                        bZeroFlag = true;
                        break;
                    }
                }
            }

            if (!bZeroFlag)
            {
                int[][,] s = new int[1][,];
                s[0] = new int[a, b];

                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        s[0][i, j] = mask[i, j];
                    }
                }

                return s;
            }
            else
            {
                int[][,] s = new int[4][,];

                s[0] = new int[a, b];
                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        s[0][i, j] = mask[i, j];
                    }
                }

                s[1] = new int[a, b];
                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        s[1][a - 1 - i, j] = mask[i, j];
                    }
                }

                s[2] = new int[a, b];
                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        s[2][i, b - 1 - j] = mask[i, j];
                    }
                }

                s[3] = new int[a, b];
                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        s[3][a-1 - i, b-1 - j] = mask[i, j];
                    }
                }

                //  check
                int[] ck = new int[4];
                for (int k = 0; k < 4; ++k)
                {
                    ck[k] = 0;
                }
                int iRepeatedCount = 0;

                for (int k = 0; k < 4; ++k)
                {
                    if (ck[k] == 1)
                    {
                        //  已经重复，需要去掉的
                        continue;
                    }

                    for (int t = k + 1; t < 4; ++t)
                    {
                        bool bSame = true;

                        for (int i = 0; i < a; ++i)
                        {
                            for (int j = 0; j < b; ++j)
                            {
                                if (s[k][i, j] != s[t][i, j])
                                {
                                    bSame = false;
                                    break;
                                }
                            }
                            if (!bSame)
                            {
                                break;
                            }
                        }

                        if (bSame)
                        {
                            ++iRepeatedCount;
                            ck[t] = 1;

                            //  不能 break
                            //  可能 x y 轴都对称，
                            //  比如 block_red_1_1
                            //  break;
                        }
                    }
                }

                if (iRepeatedCount > 0)
                {
                    int[][,] ss = new int[4 - iRepeatedCount][,];
                    int t = 0;

                    for (int k = 0; k < 4; ++k)
                    {
                        if (ck[k] == 0)
                        {
                            ss[t++] = s[k];
                        }
                    }
                    return ss;
                }

                return s;
            }
        }

        private int[][,] CreateMasks(int[,] mask)
        {
            int a = mask.GetLength(0);
            int b = mask.GetLength(1);

            int[][,] s = CheckCreateMirrorXYMasks(mask);
            if (a == b)
            {
                return s;
            }
            else
            {
                int[,] mask2 = new int[b, a];
                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        mask2[j, i] = mask[i, j];
                    }
                }
                int[][,] s2 = CheckCreateMirrorXYMasks(mask2);

                int[][,] s3 = new int[s.Length + s2.Length][,];

                for (int i = 0; i < s.Length; ++i)
                {
                    s3[i] = s[i];
                }
                for (int i = 0; i < s2.Length; ++i)
                {
                    s3[i + s.Length] = s2[i];
                }

                return s3;
            }
        }

        public Block(int v, int u)
        {
            value = v;
            unitNum = u;
        }

        //  大小为3的倍数。
        //  前1/3是水平面的摆放；后2/3是立体的摆放。
        protected readonly Point[][] Region;


        //  代表的数值
        public readonly int value;

        //  由几个单元（点）组成
        public readonly int unitNum;


        public Point[] MoveShape(int s, Point point)
        {
            if (Region != null && 0 <= s && s < Region.Length)
            {
                Point[] points = new Point[unitNum];

                for (int i = 0; i < unitNum; ++i)
                {
                    points[i] = Region[s][i] + point;
                }

                return points;
            }

            return null;
        }

        public int AllShapeCount()
        {
            return (Region == null) ? 0 : Region.Length;
        }

        public void Init(bool bZAsc)
        {
            if (Region != null)
            {
                int cnt = Region.Length;

                for (int i = 0; i < cnt; ++i)
                {
                    Region r = new Region(Region[i]);
                    r.Normalize(bZAsc);
                    // r.Print($"{i+1}");
                }
            }
        }

        public int ShapeFlatCount()
        {
            return Region == null ? 0 : Region.Length / 3;
        }
    }
}
