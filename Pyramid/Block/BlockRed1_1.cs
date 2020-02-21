using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed1_1 : IBlock
    {
        public int Value{ get => 1; }

        public int UnitNum{ get => 5; }

        public Point[,] Shapes {
            get => new Point[1,5] {
                {
                    new Point(0, 0),
                    new Point(-1, 1),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(0, 2)
                },
            };
        }
    }
}
