using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public static class ElementGroup
    {
        public static IBlock[] CreateBlocksExcludeIndex(
            this IBlock[] blocks, IBlock excludeBlock)
        {
            if (blocks != null && blocks.Length > 1 && excludeBlock != null)
            {
                IBlock[] newBlocks = new IBlock[blocks.Length - 1];
                bool bFound = false;
                int j = 0;

                for (int i = 0; i < blocks.Length; ++i)
                {
                    if (blocks[i] != excludeBlock)
                    {
                        newBlocks[j++] = blocks[i];
                    }
                    else
                    {
                        bFound = true;
                    }
                }

                if (bFound)
                {
                    return newBlocks;
                }
                else
                {
                    return blocks;
                }
            }

            return null;
        }

        public static Point[] Duplicate(this Point[] pts)
        {
            if (pts == null || pts.Length < 1)
            {
                return null;
            }

            Point[] newPts = new Point[pts.Length];
            for (int i = 0; i < pts.Length; ++i)
            {
                newPts[i] = new Point(pts[i]);
            }

            return newPts;
        }
    }
}
