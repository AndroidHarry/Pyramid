using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockWhite_12 : IBlock
    {
        public int Value { get => 12; }

        public int UnitNum { get => 5; }
        public Point[,] FlatShapes
        {
            get => new Point[4, 5] {
                {
                    /* 0
                     *     12 12 12
                     *     12    12
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(2, 1)
                },
                {
                    /* 1
                     *      12    12
                     *      12 12 12
                     */
                    new Point(0, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 2
                     *     12 12
                     *     12
                     *     12 12
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(1, 2)
                },
                {
                    /* 3
                     *     12 12
                     *        12
                     *     12 12
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(0, 2)
                }
            };
        }

        public Point[,] Shape3Ds
        {
            //  TBD
            get => null;
        }
    }
}
