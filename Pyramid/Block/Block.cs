using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public abstract class IBlock
    {
        //  代表的数值
        public readonly int value;
        
        //  分层的 region
        //  region 所在点 占且只占 一层的，位于 [0][][]
        //  region 所在点 占且只占 二层的，位于 [1][][]
        //  region 所在点 占且只占 三层的，位于 [2][][]
        //  ...
        private readonly Region[][] LayerRegion;

        //  由几个单元（点）组成
        private readonly int unitNum;

        //  对于立体拼图，
        //  true 代表 相对原点 是 更靠近底面的点，也就是 z 的小值
        //  false 代表 相对原点 是 更靠近顶点的点，也就是 z 的大值
        private bool bZAsc;


        public IBlock(int v, bool bZAsc, int[,] mask)
        {
            value = v;

            this.bZAsc = bZAsc;

            RegionMaskGroup regionMaskGroup = new RegionMaskGroup(mask);
            LayerRegion = regionMaskGroup.CreateLayerRegion();

            this.unitNum = regionMaskGroup.unitNum;

            Normalize(bZAsc);
        }
        
        public Region[] CreateRegion(int iLessLayer)
        {
            int count = GetRegionCount(iLessLayer);
            if (count > 0)
            {
                Region[] r = new Region[count];
                int t = 0;

                for (int i = 0; i < iLessLayer && i < LayerRegion.Length; ++i)
                {
                    if (LayerRegion[i] != null)
                    {
                        for (int j = 0; j < LayerRegion[i].Length; ++j)
                        {
                            r[t++] = LayerRegion[i][j];
                        }
                    }
                }

                return r;
            }

            return null;
        }

        private int GetRegionCount(int iLessLayer)
        {
            if (LayerRegion == null || iLessLayer < 1)
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < iLessLayer && i < LayerRegion.Length; ++i)
            {
                if (LayerRegion[i] != null)
                {
                    count += LayerRegion[i].Length;
                }
            }
            return count;
        }

        private void Normalize(bool bZAsc)
        {
            if (LayerRegion != null)
            {
                for (int i = 0; i < LayerRegion.Length; ++i)
                {
                    if (LayerRegion[i] != null)
                    {
                        for (int j = 0; j < LayerRegion[i].Length; ++j)
                        {
                            LayerRegion[i][j].Normalize(bZAsc);
                            // LayerRegion[i][j].Print($"Layer{i},Index{j}"); 
                        }
                    }
                }
            }
        }

        public bool CanFit(Point[] ptSrc)
        {
            if (ptSrc == null || ptSrc.Length != unitNum || LayerRegion == null)
            {
                return false;
            }

            Point[] point = ptSrc.Duplicate();

            Region r = new Region(point);
            r.Normalize(bZAsc);

            for (int i = 0; i < LayerRegion.Length; ++i)
            {
                if (LayerRegion[i] != null)
                {
                    for (int j = 0; j < LayerRegion[i].Length; ++j)
                    {
                        if (LayerRegion[i][j].CanFit(point))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
