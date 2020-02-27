using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue1_8 : IBlock
    {
        public BlockBlue1_8(bool bZAsc) : 
            base(8, bZAsc, 
                new int[,] {
                    { 1, 0, 0},
                    { 1, 0, 0},
                    { 1, 1, 1}
                })
        {
        }
    }
}
