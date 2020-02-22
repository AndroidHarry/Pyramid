using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen1_6 : IBlock
    {
        public int Value { get => 6; }

        public int UnitNum { get => 5; }

        public Point[,] FlatShapes
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

        public Point[,] Shape3Ds
        {
            get => new Point[8, 5] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 * 可能还有别的摆法 TBD
                 */
                {
                    /* 0
                     *       (0, 0, 0)
                     *       (1, 1, 0)
                     *       (0, 0, 1)
                     *       (0, 0, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3)
                },
                {
                    /* 1
                     *       (3, 0, 0)
                     *       (2, 1, 0)
                     *       (2, 0, 1)
                     *       (1, 0, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 0, 2),
                    new Point(-3, 0, 3)
                },
                {
                    /* 2
                     *       (1, 2, 0)
                     *       (0, 3, 0)
                     *       (0, 2, 1)
                     *       (0, 1, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-1, 0, 1),
                    new Point(-1, -1, 2),
                    new Point(-1, -2, 3)
                },
                {
                    /* 3
                     *       (2, 2, 0)
                     *       (3, 3, 0)
                     *       (2, 2, 1)
                     *       (1, 1, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(-1, -1, 2),
                    new Point(-2, -2, 3)
                },
                {
                    /* 4
                     *       (0, 0, 0)
                     *       (0, 0, 1)
                     *       (1, 1, 1)
                     *       (0, 0, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3)
                },
                {
                    /* 5
                     *       (3, 0, 0)
                     *       (2, 0, 1)
                     *       (1, 1, 1)
                     *       (1, 0, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 1, 1),
                    new Point(-2, 0, 2),
                    new Point(-3, 0, 3)
                },
                {
                    /* 6
                     *       (0, 3, 0)
                     *       (3, 3, 1)
                     *       (1, 1, 1)
                     *       (0, 1, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(3, 0, 1),
                    new Point(1, -2, 1),
                    new Point(0, -2, 2),
                    new Point(0, -3, 3)
                },
                {
                    /* 7
                     *       (3, 3, 0)
                     *       (1, 1, 1)
                     *       (2, 2, 1)
                     *       (1, 1, 2)
                     *       (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-2, -2, 1),
                    new Point(-1, -1, 1),
                    new Point(-2, -2, 2),
                    new Point(-3, -3, 3)
                }
            };
        }
    }
}
