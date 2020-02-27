using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink2_4 : IBlock
    {
        public BlockPink2_4(bool bZAsc) : 
            base(4, bZAsc, 
                new int[,] {
                    { 1, 0, 0, 0},
                    { 1, 1, 1, 1},
                })
        {
        }
    }
}
