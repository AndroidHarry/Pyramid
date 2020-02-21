using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPurple_5 : IBlock
    {
        public int Value { get => 5; }

        public int UnitNum { get => 5; }

        public Point[,] Shapes
        {
            get => new Point[8, 5] {
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(2, 1),
                    new Point(3, 1)
                },
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(-1, 1),
                    new Point(-2, 1),
                    new Point(0, 1)
                },
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(2, 1),
                    new Point(3, 1)
                },
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 0),
                    new Point(-1, 1)
                },
                {
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(1, 3)
                },
                {
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(-1, 2),
                    new Point(-1, 3)
                },
                {
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(1, 2),
                    new Point(1, 3)
                },
                {
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(-1, 2),
                    new Point(-1, 3)
                }
            };
        }
    }
}
