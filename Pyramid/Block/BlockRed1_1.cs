using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed1_1 : IBlock
    {
        public BlockRed1_1(bool bZAsc) : 
            base(1, bZAsc, 
                new int[,] {
                    { 0, 1, 0},
                    { 1, 1, 1},
                    { 0, 1, 0}
                })
        {
        }
    }
}
