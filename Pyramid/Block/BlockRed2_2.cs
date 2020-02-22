using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed2_2 : IBlock
    {
        public int Value { get => 2; }

        public int UnitNum { get => 5; }

        public Point[,] FlatShapes
        {
            get => new Point[4, 5] {
                {
                    /* 0
                     *    2
                     *    2 2
                     *      2 2
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(2, 2)
                },
                {
                    /* 1
                     *       2
                     *     2 2
                     *   2 2
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(-1, 2),
                    new Point(-2, 2)
                },
                {
                    /* 2
                     *     2 2
                     *       2 2
                     *         2
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(2, 1),
                    new Point(2, 2)
                },
                {
                    /* 3
                     *       2 2
                     *     2 2
                     *     2
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(-1, 2)
                }
            };
        }

        public Point[,] Shape3Ds {
            get => new Point[2, 5] {
                /*
                 * 与底面垂直站立放置
                 */
                {
                    /* 0
                     *    (2, 0, 0)
                     *    (1, 1, 0)
                     *    (0, 2, 0)
                     *    (1, 0, 1)
                     *    (0, 1, 1)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-2, 2, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 1, 1)
                },
                {
                    /* 1
                     *    (2, 0, 0)
                     *    (3, 1, 0)
                     *    (4, 2, 0)
                     *    (2, 0, 1)
                     *    (3, 1, 1)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(2, 2, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1)
                }
            };
        }
    }
}
