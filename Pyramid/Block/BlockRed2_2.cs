using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed2_2 : IBlock
    {
        public BlockRed2_2(bool bZAsc) : 
            base(2, bZAsc, 
                new int[,] {
                    { 1, 0, 0},
                    { 1, 1, 0},
                    { 0, 1, 1}
                })
        {
        }
    }
}
