using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public static class BlockHelper
    {
        public static int ShapeCount(this IBlock block)
        {
            return block.Shapes.Length / block.UnitNum;
        }

        public static Point[] Shape(this IBlock block, int s, Point point)
        {
            Point[] points = new Point[block.UnitNum];

            for (int i = 0; i < block.UnitNum; ++i)
            {
                points[i] = block.Shapes[s, i] + point;
            }

            return points;
        }

        public static IBlock[] CreateBlocksExcludeIndex(this IBlock[] blocks, int excludeIdx)
        {
            if (blocks.Length > 1 && 0 <= excludeIdx && excludeIdx < blocks.Length)
            {
                IBlock[] newBlocks = new IBlock[blocks.Length - 1];
                int j = 0;

                for (int i = 0; i < blocks.Length; ++i)
                {
                    if (i != excludeIdx)
                    {
                        newBlocks[j++] = blocks[i];
                    }
                }

                return newBlocks;
            }

            return null;
        }

        public static int GetBlockIndexByValue(this IBlock[] blocks, int value)
        {
            if (blocks == null || blocks.Length < 1)
            {
                return -1;
            }

            for (int i = 0; i < blocks.Length; ++i)
            {
                if (blocks[i].Value == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
