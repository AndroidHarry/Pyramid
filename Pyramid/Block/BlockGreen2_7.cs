using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen2_7 : IBlock
    {
        public int Value { get => 7; }

        public int UnitNum { get => 4; }

        public Point[,] Shapes
        {
            get => new Point[2, 4] {
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0)
                },
                {
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3)
                }
            };
        }
    }
}
