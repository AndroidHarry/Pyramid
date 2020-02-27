using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGrey_11 : IBlock
    {
        public BlockGrey_11(bool bZAsc) : 
            base(11, bZAsc, 
                new int[,] {
                    { 1, 0, 0},
                    { 1, 1, 1},
                })
        {
        }
    }
}
