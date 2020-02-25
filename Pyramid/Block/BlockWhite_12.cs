using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockWhite_12 : Block
    {
        public BlockWhite_12() : 
            base(12,
                new int[,] {
                    { 1, 1, 1},
                    { 1, 0, 1},
                })
        {
        }
    }
}
