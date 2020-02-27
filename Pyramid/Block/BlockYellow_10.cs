using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockYellow_10 : IBlock
    {
        public BlockYellow_10(bool bZAsc) : 
            base(10, bZAsc, 
                new int[,] {
                    { 1, 1},
                    { 1, 1},
                })
        {
        }
    }
}
