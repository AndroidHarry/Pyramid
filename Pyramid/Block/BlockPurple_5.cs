using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPurple_5 : Block
    {
        public BlockPurple_5() : base(5, 5)
        {
            FlatShapes = new Point[8, 5] {
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

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 */
                new Point[]
                {
                    // 0
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(1, 1, 1),
                    new Point(1, 1, 2)
                },
                new Point[]
                {
                    // 1
                    new Point(3, 0, 0),
                    new Point(2, 0, 1),
                    new Point(1, 0, 2),
                    new Point(1, 1, 1),
                    new Point(0, 1, 2),
                },
                new Point[]
                {
                    // 2
                    new Point(0, 3, 0),
                    new Point(0, 2, 1),
                    new Point(0, 1, 2),
                    new Point(1, 1, 1),
                    new Point(1, 0, 2),
                },
                new Point[]
                {
                    // 3
                    new Point(3, 3, 0),
                    new Point(2, 2, 1),
                    new Point(1, 1, 2),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2),
                },
                new Point[]
                {
                    // 4
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(1, 1, 2)
                },
                new Point[]
                {
                    // 5
                    new Point(4, 0, 0),
                    new Point(3, 1, 0),
                    new Point(3, 0, 1),
                    new Point(2, 1, 1),
                    new Point(1, 1, 2),
                },
                new Point[]
                {
                    // 6
                    new Point(1, 3, 0),
                    new Point(0, 4, 0),
                    new Point(0, 3, 1),
                    new Point(1, 2, 1),
                    new Point(1, 1, 2),
                },
                new Point[]
                {
                    // 7
                    new Point(3, 3, 0),
                    new Point(4, 4, 0),
                    new Point(3, 3, 1),
                    new Point(2, 2, 1),
                    new Point(1, 1, 2),
                }
            };
        }
    }
}
