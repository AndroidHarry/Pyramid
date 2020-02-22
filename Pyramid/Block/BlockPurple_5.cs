using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPurple_5 : IBlock
    {
        public int Value { get => 5; }

        public int UnitNum { get => 5; }

        public Point[,] FlatShapes
        {
            get => new Point[8, 5] {
                {
                    /* 0
                     *    5 5
                     *      5 5 5
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(2, 1),
                    new Point(3, 1)
                },
                {
                    /* 1
                     *      5 5
                     *  5 5 5
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(-1, 1),
                    new Point(-2, 1),
                    new Point(0, 1)
                },
                {
                    /* 2
                     *      5 5 5
                     *          5 5
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(2, 1),
                    new Point(3, 1)
                },
                {
                    /* 3
                     *      5 5 5
                     *    5 5
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 0),
                    new Point(-1, 1)
                },
                {
                    /* 4
                     *      5
                     *      5 5
                     *        5
                     *        5
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(1, 3)
                },
                {
                    /* 5
                     *      5
                     *    5 5
                     *    5
                     *    5
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(-1, 2),
                    new Point(-1, 3)
                },
                {
                    /* 6
                     *      5
                     *      5
                     *      5 5
                     *        5
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(1, 2),
                    new Point(1, 3)
                },
                {
                    /* 7
                     *      5
                     *      5
                     *    5 5
                     *    5
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(-1, 2),
                    new Point(-1, 3)
                }
            };
        }

        public Point[,] Shape3Ds
        {
            get => new Point[8, 5] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 */
                {
                    /* 0
                     *    (0, 0, 0)
                     *    (0, 0, 1)
                     *    (0, 0, 2)
                     *    (1, 1, 1)
                     *    (1, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(1, 1, 1),
                    new Point(1, 1, 2)
                },
                {
                    /* 1
                     *     (3, 0, 0)
                     *     (2, 0, 1)
                     *     (1, 0, 2)
                     *     (1, 1, 1)
                     *     (0, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 0, 2),
                    new Point(-2, 1, 1),
                    new Point(-3, 1, 2)
                },
                {
                    /* 2
                     *    (0, 3, 0)
                     *    (0, 2, 1)
                     *    (0, 1, 2)
                     *    (1, 1, 1)
                     *    (1, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(0, -1, 1),
                    new Point(0, -2, 2),
                    new Point(1, -2, 1),
                    new Point(1, -3, 2)
                },
                {
                    /* 3
                     *     (3, 3, 0)
                     *     (2, 2, 1)
                     *     (1, 1, 2)
                     *     (1, 1, 1)
                     *     (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, -1, 1),
                    new Point(-2, -2, 2),
                    new Point(-2, -2, 1),
                    new Point(-3, -3, 2)
                },
                {
                    /* 4
                     *    (0, 0, 0)
                     *    (1, 1, 0)
                     *    (0, 0, 1)
                     *    (1, 1, 1)
                     *    (1, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(1, 1, 2)
                },
                {
                    /* 5
                     *    (4, 0, 0)
                     *    (3, 1, 0)
                     *    (3, 0, 1)
                     *    (2, 1, 1)
                     *    (1, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 1, 1),
                    new Point(-3, 1, 2)
                },
                {
                    /* 6
                     *    (1, 3, 0)
                     *    (0, 4, 0)
                     *    (0, 3, 1)
                     *    (1, 2, 1)
                     *    (1, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-1, 0, 1),
                    new Point(0, -1, 1),
                    new Point(0, -2, 2)
                },
                {
                    /* 7
                     *    (3, 3, 0)
                     *    (4, 4, 0)
                     *    (3, 3, 1)
                     *    (2, 2, 1)
                     *    (1, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(-1, -1, 1),
                    new Point(-2, -2, 2)
                }
            };
        }
    }
}
