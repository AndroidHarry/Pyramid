using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public static class BlockHelper
    {
        public static int ShapeFlatCount(this IBlock block)
        {
            return block.FlatShapes.Length / block.UnitNum;
        }

        public static int Shape3DCount(this IBlock block)
        {
            if (block.Shape3Ds != null)
            {
                return block.Shape3Ds.Length / block.UnitNum;
            }

            return 0;
        }

        public static int AllShapeCount(this IBlock block)
        {
            return block.ShapeFlatCount() + block.Shape3DCount();
        }

        public static Point[] ShapeFlat(this IBlock block, int s, Point point)
        {
            Point[] points = new Point[block.UnitNum];

            for (int i = 0; i < block.UnitNum; ++i)
            {
                points[i] = block.FlatShapes[s, i] + point;
            }

            return points;
        }

        public static Point[] Shape3D(this IBlock block, int s, Point point)
        {
            if (block.Shape3Ds == null)
                return null;

            if (s >= block.Shape3DCount())
                return null;

            Point[] points = new Point[block.UnitNum];

            for (int i = 0; i < block.UnitNum; ++i)
            {
                points[i] = block.Shape3Ds[s, i] + point;
            }

            return points;
        }

        public static Point[] Shape(this IBlock block, int s, Point point)
        {
            if (s < 0)
                return null;

            if (s < block.ShapeFlatCount())
                return block.ShapeFlat(s, point);

            return block.Shape3D(s - block.ShapeFlatCount(), point);
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
