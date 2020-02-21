﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockYellow_10 : IBlock
    {
        public int Value { get => 10; }

        public int UnitNum { get => 4; }

        public Point[,] Shapes
        {
            get => new Point[1, 4] {
                {
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1)
                }
            };
        }
    }
}
