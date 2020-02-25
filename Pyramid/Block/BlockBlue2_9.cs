using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue2_9 : Block
    {
        public BlockBlue2_9() : 
            base(9,
                new int[,] {
                    { 1, 1, 0},
                    { 1, 1, 1},
                })
        {
        }
    }
}
