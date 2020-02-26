using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid
{
    /// <summary>
    /// 从 int[,] mask 构造出 Region[][]
    /// 其中, Region[i] 代表可以摆放成 i 层的 Region 的集合
    /// 
    /// 比如, Region[0] 代表可以摆放成 1 层的 Region 的集合，
    /// 其实就是把积木水平放置的摆法的集合
    /// 
    /// 比如，Region[1] 代表可以摆放成 2 层的 Region 的集合，
    /// 其实就是把积木垂直放置的摆法的集合，如 BlockPink1_3 的垂直摆放的集合。
    /// 
    /// </summary>
    public class RegionMaskGroup
    {
        //  初始掩码
        private readonly int[,] mask;

        //  由几个单元（点）组成
        private readonly int unitNum;


        public RegionMaskGroup(int[,] mask)
        {
            this.mask = mask;

            #region 计算 unitNum
            int a = mask.GetLength(0);
            int b = mask.GetLength(1);

            unitNum = 0;

            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    if (mask[i, j] == 1)
                    {
                        ++unitNum;
                    }
                }
            }
            #endregion
        }

        public Region[][] CreateLayerRegion()
        {
            int[][,] masks = CreateAllMasks(mask);

            Region[] regions = CreateRegion(masks);
            if (regions != null)
            {
                return CreateLayerRegion(regions);
            }
            else
            {
                return null;
            }
        }

        #region Region
        private Region[][] CreateLayerRegion(Region[] allRegion)
        {
            int maxLayer = RegionMaxLayer(allRegion);

            Region[][] r = new Region[maxLayer + 1][];

            for (int i = 0; i <= maxLayer; ++i)
            {
                r[i] = CreateLayerRegion(allRegion, i);
            }

            return r;
        }

        private Region[] CreateLayerRegion(Region[] allRegion, int layer)
        {
            if (allRegion == null)
            {
                return null;
            }

            int count = 0;

            for (int i = 0; i < allRegion.Length; ++i)
            {
                if (allRegion[i].LayerCount == layer)
                {
                    ++count;
                }
            }

            if (count > 0)
            {
                Region[] r = new Region[count];
                int j = 0;

                for (int i = 0; i < allRegion.Length; ++i)
                {
                    if (allRegion[i].LayerCount == layer)
                    {
                        r[j++] = allRegion[i];
                    }
                }

                return r;
            }

            return null;
        }

        private int RegionMaxLayer(Region[] allRegion)
        {
            if (allRegion == null || allRegion.Length == 0)
            {
                return 0;
            }

            int m = 0;
            foreach (Region r in allRegion)
            {
                if (r.LayerCount > m)
                {
                    m = r.LayerCount;
                }
            }

            return m;
        }

        private Region[] CreateRegion(int[][,] masks)
        {
            int a = masks.Length;

            Region[] rg = new Region[a * 3];

            for (int k = 0; k < a; ++k)
            {
                Point[] pts_0 = new Point[unitNum];
                Point[] pts_1 = new Point[unitNum];
                Point[] pts_2 = new Point[unitNum];

                int t = 0;
                for (int i = 0; i < masks[k].GetLength(0); ++i)
                {
                    for (int j = 0; j < masks[k].GetLength(1); ++j)
                    {
                        if (masks[k][i, j] == 1)
                        {
                            /*
                             *   A         B
                             *    * * * * *
                             *    * * * * *
                             *    * * * * *
                             *    * * * * *
                             *   C         D
                             */
                            //  平面摆放，直接根据 x, y 来赋值
                            pts_0[t] = new Point(i, j);
                            //  立体摆放，积木所在平面与正方形ABCD所在底面垂直，
                            //  且对角线AD平行于积木所在平面
                            pts_1[t] = new Point(j, j, -i - j);
                            //  立体摆放，积木所在平面与正方形ABCD所在底面垂直，
                            //  且对角线BC平行于积木所在平面
                            pts_2[t] = new Point(j, i, -i - j);

                            ++t;
                        }
                    }
                }

                rg[k] = new Region(pts_0);
                rg[k + a] = new Region(pts_1);
                rg[k + a + a] = new Region(pts_2);
            }

            return rg;
        }
        #endregion

        #region mask
        private int[][,] CreateAllMasks(int[,] mask)
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
                //  mask 全为 1
                //  说明 x, y 全对称
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
                        s[3][a - 1 - i, b - 1 - j] = mask[i, j];
                    }
                }

                //  check
                //  去除重复的 mask
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
        #endregion
    }
}
