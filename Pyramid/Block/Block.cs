using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public abstract class Block
    {
        //  代表的数值
        public readonly int value;
        
        //  分层的 region
        //  region 所在点 占且只占 一层的，位于 [0][][]
        //  region 所在点 占且只占 二层的，位于 [1][][]
        //  region 所在点 占且只占 三层的，位于 [2][][]
        //  ...
        private readonly Region[][] LayerRegion;


        public Block(int v, int[,] mask)
        {
            value = v;

            LayerRegion = new RegionMaskGroup(mask).CreateLayerRegion();
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

        public void Init(bool bZAsc)
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
    }
}
