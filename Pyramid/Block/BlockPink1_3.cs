using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink1_3 : IBlock
    {
        public BlockPink1_3(bool bZAsc) :
            base(3, bZAsc, 
                new int[,] {
                    { 1, 0},
                    { 1, 1},
                })
        {
        }
    }
}
