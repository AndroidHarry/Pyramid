using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPurple_5 : IBlock
    {
        public BlockPurple_5(bool bZAsc) : 
            base(5, bZAsc, 
                new int[,] {
                    { 1, 1, 0, 0},
                    { 0, 1, 1, 1},
                })
        {
        }
    }
}
