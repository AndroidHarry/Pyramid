using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen2_7 : IBlock
    {
        public BlockGreen2_7(bool bZAsc) : 
            base(7, bZAsc, 
                new int[,] {
                    { 1, 1, 1, 1},
                })
        {
        }
    }
}
