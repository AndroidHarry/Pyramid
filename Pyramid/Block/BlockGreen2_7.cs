using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen2_7 : IBlock
    {
        public int Value { get => 7; }

        public int UnitNum { get => 4; }

        public Point[,] FlatShapes
        {
            get => new Point[2, 4] {
                {
                    /* 0
                     *     7 7 7 7
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0)
                },
                {
                    /* 1
                     *    7
                     *    7
                     *    7
                     *    7
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3)
                }
            };
        }

        public Point[,] Shape3Ds
        {
            get => new Point[4, 4] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 */
                {
                    /* 0 
                     *       (0, 0, 0)
                     *       (0, 0, 1)
                     *       (0, 0, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3)
                },
                {
                    /* 1 
                     *       (3, 0, 0)
                     *       (2, 0, 1)
                     *       (1, 0, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 0, 2),
                    new Point(-3, 0, 3)
                },
                {
                    /* 2 
                     *       (0, 3, 0)
                     *       (0, 2, 1)
                     *       (0, 1, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(0, -1, 1),
                    new Point(0, -2, 2),
                    new Point(0, -3, 3)
                },
                {
                    /* 3 
                     *       (3, 3, 0)
                     *       (2, 2, 1)
                     *       (1, 1, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, -1, 1),
                    new Point(-2, -2, 2),
                    new Point(-3, -3, 3)
                },
            };
        }
    }
}
