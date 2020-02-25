using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue1_8 : Block
    {
        public BlockBlue1_8() : 
            base(8,
                new int[,] {
                    { 1, 0, 0},
                    { 1, 0, 0},
                    { 1, 1, 1}
                })
        {
        }
    }
}
