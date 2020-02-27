using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockWhite_12 : IBlock
    {
        public BlockWhite_12(bool bZAsc) : 
            base(12, bZAsc, 
                new int[,] {
                    { 1, 1, 1},
                    { 1, 0, 1},
                })
        {
        }
    }
}
