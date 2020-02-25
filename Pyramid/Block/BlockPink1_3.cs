using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink1_3 : Block
    {
        public BlockPink1_3() :
            base(3,
                new int[,] {
                    { 1, 0},
                    { 1, 1},
                })
        {
        }
    }
}
