using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public static class BlockGroup
    {
        public static Block[] CreateAll(bool bZAsc)
        {
            Block[] blocks = new Block[] {
                new BlockPink2_4(),
                new BlockRed1_1(), new BlockRed2_2(),
                new BlockPurple_5(),
                new BlockGreen1_6(),
                new BlockGreen2_7(),
                new BlockBlue1_8(), new BlockBlue2_9(),
                new BlockYellow_10(),
                new BlockGrey_11(),
                new BlockPink1_3(),
                new BlockWhite_12()
            };

            for (int i = 0; i < blocks.Length; ++i)
            {
                blocks[i].Init(bZAsc);
            }

            return blocks;
        }

        public static Block[] CreateBlocksExcludeIndex(this Block[] blocks, int excludeIdx)
        {
            if (blocks.Length > 1 && 0 <= excludeIdx && excludeIdx < blocks.Length)
            {
                Block[] newBlocks = new Block[blocks.Length - 1];
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

        public static int GetBlockIndexByValue(this Block[] blocks, int value)
        {
            if (blocks == null || blocks.Length < 1)
            {
                return -1;
            }

            for (int i = 0; i < blocks.Length; ++i)
            {
                if (blocks[i].value == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
