using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue1_8 : Block
    {
        public BlockBlue1_8() : base(8, 5)
        {
            FlatShapes = new Point[4, 5] {
                {
                    /* 0
                     *     8
                     *     8
                     *     8 8 8
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(1, 2),
                    new Point(2, 2)
                },
                {
                    /* 1
                     *        8
                     *        8
                     *    8 8 8
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(-1, 2),
                    new Point(-2, 2)
                },
                {
                    /* 2
                     *          8 8 8
                     *          8
                     *          8
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(0, 2)
                },
                {
                    /* 3
                     *      8 8 8
                     *          8
                     *          8
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(2, 1),
                    new Point(2, 2)
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
                    new Point(2, 2, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2)
                },
                new Point[]
                {
                    // 1
                    new Point(2, 0, 0),
                    new Point(0, 2, 0),
                    new Point(1, 0, 1),
                    new Point(0, 1, 1),
                    new Point(0, 0, 2),
                },
                new Point[]
                {
                    // 2 V
                    new Point(2, 2, 0),
                    new Point(1, 1, 1),
                    new Point(2, 2, 1),
                    new Point(0, 0, 2),
                    new Point(2, 2, 2),
                },
                new Point[]
                {
                    // 3 V
                    new Point(2, 2, 0),
                    new Point(2, 1, 1),
                    new Point(1, 2, 1),
                    new Point(2, 0, 2),
                    new Point(0, 2, 2),
                },
            };
        }
    }
}
