using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockYellow_10 : IBlock
    {
        public int Value { get => 10; }

        public int UnitNum { get => 4; }

        public Point[,] FlatShapes
        {
            get => new Point[1, 4] {
                {
                    /* 0
                     *     10 10
                     *     10 10
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1)
                }
            };
        }

        public Point[,] Shape3Ds
        {
            get => new Point[2, 4] {
                /*
                 * 与底面垂直站立放置
                 * 边与底面成 45 度角
                 */
                {
                    /* 0
                     *    (1, 1, 0)
                     *    (0, 0, 1)
                     *    (1, 1, 1)
                     *    (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, -1, 1),
                    new Point(0, 0, 1),
                    new Point(-1, -1, 2)
                },
                {
                    /* 1
                     *     (3, 1, 0)
                     *     (3, 0, 1)
                     *     (2, 1, 1)
                     *     (2, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(0, -1, 1),
                    new Point(-1, 0, 1),
                    new Point(-1, -1, 2)
                },
            };
        }
    }
}
