using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink2_4 : Block
    {
        public BlockPink2_4() : base(4, 5)
        {
            FlatShapes = new Point[8, 5] {
                {
                    /* 0
                     *     4
                     *     4 4 4 4
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1),
                    new Point(3, 1)
                },
                {
                    /* 1
                     *         4
                     *   4 4 4 4
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(-2, 1),
                    new Point(-3, 1)
                },
                {
                    /* 2
                     *    4 4 4 4
                     *    4
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0),
                    new Point(0, 1)
                },
                {
                    /* 3
                     *    4 4 4 4
                     *          4
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0),
                    new Point(3, 1)
                },
                {
                    /* 4
                     *    4
                     *    4
                     *    4
                     *    4 4
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3),
                    new Point(1, 3)
                },
                {
                    /* 5
                     *     4
                     *     4
                     *     4
                     *   4 4
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3),
                    new Point(-1, 3)
                },
                {
                    /* 6
                     *     4 4
                     *       4
                     *       4
                     *       4
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(1, 3)
                },
                {
                    /* 7
                     *      4 4
                     *      4
                     *      4
                     *      4
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(0, 3)
                }
            };

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 * refer to BlockGrey_11
                 * 摆放总数为 4*4=16 种 TBD
                 */
                new Point[]
                {
                    // 0
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3),
                    new Point(1, 1, 2)
                },
                new Point[]
                {
                    // 1
                    new Point(3, 0, 0),
                    new Point(2, 0, 1),
                    new Point(1, 0, 2),
                    new Point(0, 0, 3),
                    new Point(0, 1, 2),
                },
                new Point[]
                {
                    // 2
                    new Point(0, 3, 0),
                    new Point(0, 2, 1),
                    new Point(0, 1, 2),
                    new Point(0, 0, 3),
                    new Point(1, 0, 2),
                },
                new Point[]
                {
                    // 3
                    new Point(3, 3, 0),
                    new Point(2, 2, 1),
                    new Point(1, 1, 2),
                    new Point(0, 0, 3),
                    new Point(0, 0, 2),
                }
            };
        }
    }
}
