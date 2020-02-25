using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed2_2 : Block
    {
        public BlockRed2_2() : 
            base(2, 
                new int[,] {
                    { 1, 0, 0},
                    { 1, 1, 0},
                    { 0, 1, 1}
                })
        {
        }
    }
}
