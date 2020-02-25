using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPurple_5 : Block
    {
        public BlockPurple_5() : 
            base(5,
                new int[,] {
                    { 1, 1, 0, 0},
                    { 0, 1, 1, 1},
                })
        {
        }
    }
}
