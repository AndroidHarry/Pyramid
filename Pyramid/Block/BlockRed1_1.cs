using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed1_1 : Block
    {
        public BlockRed1_1() : 
            base(1,
                new int[,] {
                    { 0, 1, 0},
                    { 1, 1, 1},
                    { 0, 1, 0}
                })
        {
        }
    }
}
