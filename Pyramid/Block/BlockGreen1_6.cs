using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen1_6 : Block
    {
        public BlockGreen1_6() : 
            base(6,
                new int[,] {
                    { 0, 1, 0, 0},
                    { 1, 1, 1, 1},
                })
        {
        }
    }
}
