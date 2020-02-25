using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink2_4 : Block
    {
        public BlockPink2_4() : 
            base(4,
                new int[,] {
                    { 1, 0, 0, 0},
                    { 1, 1, 1, 1},
                })
        {
        }
    }
}
