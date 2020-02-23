using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink1_3 : Block
    {
        public BlockPink1_3() : base(3, 3)
        {
            FlatShapes = new Point[4, 3] {
                {
                    /* 0
                     *     3
                     *   3 3
                     */
                    new Point(0, 0),
                    new Point(-1, 1),
                    new Point(0, 1)
                },
                {
                    /* 0
                     *     3
                     *     3 3
                     */
                    new Point(0, 0),
                    new Point(1, 1),
                    new Point(0, 1)
                },
                {
                    /* 0
                     *     3 3
                     *     3
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1)
                },
                {
                    /* 3
                     *     3 3
                     *       3
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1)
                }
            };

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 * TBD 还有摆放方式
                 */
                new Point[]
                {
                    // 0
                    new Point(1, 0, 0),
                    new Point(0, 1, 0),
                    new Point(0, 0, 1),
                },
                new Point[]
                {
                    // 1
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1)
                },
                new Point[]
                {
                    // 2
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                },
                new Point[]
                {
                    // 3
                    new Point(1, 1, 0),
                    new Point(1, 0, 1),
                    new Point(0, 0, 2),
                },
                new Point[]
                {
                    // 4
                    new Point(1, 1, 0),
                    new Point(0, 1, 1),
                    new Point(0, 0, 2),
                },
                new Point[]
                {
                    // 5
                    new Point(1, 1, 0),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2),
                }
            };
        }
    }
}
