using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockYellow_10 : Block
    {
        public BlockYellow_10() : base(10, 4)
        {
            FlatShapes = new Point[1, 4] {
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

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 * 边与底面成 45 度角
                 */
                new Point[]
                {
                    // 0
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2),
                },
                new Point[]
                {
                    // 1
                    new Point(3, 1, 0),
                    new Point(3, 0, 1),
                    new Point(2, 1, 1),
                    new Point(2, 0, 2),
                },
            };
        }
    }
}
