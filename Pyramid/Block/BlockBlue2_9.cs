using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue2_9 : IBlock
    {
        public BlockBlue2_9(bool bZAsc) : 
            base(9, bZAsc, 
                new int[,] {
                    { 1, 1, 0},
                    { 1, 1, 1},
                })
        {
        }
    }
}
