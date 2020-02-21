using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue2_9 : IBlock
    {
        public int Value { get => 9; }

        public int UnitNum { get => 5; }

        public Point[,] Shapes
        {
            get => new Point[8, 5] {
                {
                    /* 0
                     *    9 9
                     *    9 9 9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 1
                     *    9 9
                     *  9 9 9 
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(-1, 1)
                },
                {
                    /* 2
                     *    9 9 9
                     *    9 9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(1, 1)
                },
                {
                    /* 3
                     *    9 9 9
                     *      9 9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 4
                     *   9 
                     *   9 9
                     *   9 9
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(0, 2),
                    new Point(1, 2)
                },
                {
                    /* 5
                     *     9
                     *   9 9
                     *   9 9
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(0, 2),
                    new Point(-1, 2)
                },
                {
                    /* 6
                     *     9 9 
                     *     9 9
                     *     9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(0, 2)
                },
                {
                    /* 7
                     *     9 9
                     *     9 9
                     *       9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(1, 2)
                }
            };
        }
    }
}
