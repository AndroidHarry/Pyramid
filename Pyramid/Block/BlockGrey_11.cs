using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGrey_11 : Block
    {
        public BlockGrey_11() : 
            base(11,
                new int[,] {
                    { 1, 0, 0},
                    { 1, 1, 1},
                })
        {
        }
    }
}
