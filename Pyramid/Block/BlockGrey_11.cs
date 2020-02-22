using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGrey_11 : IBlock
    {
        public int Value { get => 11; }

        public int UnitNum { get => 4; }

        public Point[,] FlatShapes
        {
            get => new Point[8, 4] {
                {
                    /* 0
                     *       11
                     *       11 11 11
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 1
                     *          11
                     *    11 11 11
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(-2, 1)
                },
                {
                    /* 2
                     *       11 11 11
                     *       11
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 1)
                },
                {
                    /* 3
                     *     11 11 11
                     *           11
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(2, 1)
                },
                {
                    /* 4
                     *      11
                     *      11
                     *      11 11
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(1, 2)
                },
                {
                    /* 5
                     *      11
                     *      11
                     *   11 11
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(-1, 2)
                },
                {
                    /* 6
                     *      11 11
                     *      11
                     *      11
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(0, 2)
                },
                {
                    /* 7
                     *     11 11
                     *        11
                     *        11
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(1, 2)
                }
            };
        }

        public Point[,] Shape3Ds
        {
            get => new Point[4, 4] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 * refer to BlockPink2_4
                 * 摆放总数为 4*4=16 种 TBD
                 */
                {
                    /* 0
                     *    (0, 0, 0)
                     *    (0, 0, 1)
                     *    (0, 0, 2)
                     *    (1, 1, 1)
                     */
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(1, 1, 1)
                },
                {
                    /* 1
                     *     (2, 0, 1)
                     *     (1, 0, 2)
                     *     (0, 0, 3)
                     *     (0, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 0, 1),
                    new Point(-2, 0, 2),
                    new Point(-2, 1, 1)
                },
                {
                    /* 2
                     *     (0, 2, 1)
                     *     (0, 1, 2)
                     *     (0, 0, 3)
                     *     (1, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(0, -1, 1),
                    new Point(0, -2, 2),
                    new Point(1, -2, 1)
                },
                {
                    /* 3
                     *     (2, 2, 1)
                     *     (1, 1, 2)
                     *     (0, 0, 3)
                     *     (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, -1, 1),
                    new Point(-2, -2, 2),
                    new Point(-2, -2, 1)
                }
            };
        }
    }
}
