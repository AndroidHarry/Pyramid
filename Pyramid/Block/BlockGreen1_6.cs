using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen1_6 : IBlock
    {
        public int Value { get => 6; }

        public int UnitNum { get => 5; }

        public Point[,] Shapes
        {
            get => new Point[8, 5] {
                {
                    /* 0
                     *    6
                     *  6 6 6 6
                     */
                    new Point(0, 0),
                    new Point(-1, 1),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 1
                     *      6
                     *  6 6 6 6
                     */
                    new Point(0, 0),
                    new Point(-2, 1),
                    new Point(-1, 1),
                    new Point(0, 1),
                    new Point(1, 1)
                },
                {
                    /* 2
                     *  6 6 6 6
                     *      6
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0),
                    new Point(2, 1)
                },
                {
                    /* 3
                     *  6 6 6 6
                     *    6
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0),
                    new Point(1, 1)
                },
                {
                    /* 4
                     *   6
                     *   6 6
                     *   6
                     *   6
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3),
                    new Point(1, 1)
                },
                {
                    /* 5
                     *    6
                     *  6 6
                     *    6
                     *    6
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3),
                    new Point(-1, 1)
                },
                {
                    /* 6
                     *    6
                     *    6
                     *    6 6
                     *    6
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3),
                    new Point(1, 2)
                },
                {
                    /* 7
                     *    6
                     *    6
                     *  6 6
                     *    6
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3),
                    new Point(-1, 2)
                }
            };
        }
    }
}
