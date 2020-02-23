using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen2_7 : Block
    {
        public BlockGreen2_7() : base(7, 4)
        {
            FlatShapes = new Point[2, 4] {
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
                    new Point(0, 0, 3)
                },
                new Point[]
                {
                    // 1 
                    new Point(3, 0, 0),
                    new Point(2, 0, 1),
                    new Point(1, 0, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 2
                    new Point(0, 3, 0),
                    new Point(0, 2, 1),
                    new Point(0, 1, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 3
                    new Point(3, 3, 0),
                    new Point(2, 2, 1),
                    new Point(1, 1, 2),
                    new Point(0, 0, 3),
                },
            };
        }
    }
}
