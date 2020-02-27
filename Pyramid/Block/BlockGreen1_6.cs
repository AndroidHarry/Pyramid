using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen1_6 : IBlock
    {
        public BlockGreen1_6(bool bZAsc) : 
            base(6, bZAsc, 
                new int[,] {
                    { 0, 1, 0, 0},
                    { 1, 1, 1, 1},
                })
        {
        }
    }
}
