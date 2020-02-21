using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink1_3 : IBlock
    {
        public int Value { get => 3; }

        public int UnitNum { get => 3; }

        public Point[,] Shapes
        {
            get => new Point[4, 3] {
                {
                    new Point(0, 0),
                    new Point(-1, 1),
                    new Point(0, 1)
                },
                {
                    new Point(0, 0),
                    new Point(1, 1),
                    new Point(0, 1)
                },
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1)
                },
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1)
                }
            };
        }
    }
}
