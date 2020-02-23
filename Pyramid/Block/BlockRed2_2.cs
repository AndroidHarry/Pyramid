using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed2_2 : Block
    {
        public BlockRed2_2() : base(2, 5)
        {
            FlatShapes = new Point[4, 5] {
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

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 */
                new Point[]
                {
                    // 0
                    new Point(2, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 2, 0),
                    new Point(1, 0, 1),
                    new Point(0, 1, 1),
                },
                new Point[]
                {
                    // 1
                    new Point(2, 0, 0),
                    new Point(3, 1, 0),
                    new Point(4, 2, 0),
                    new Point(2, 0, 1),
                    new Point(3, 1, 1),
                }
            };
        }
    }
}
