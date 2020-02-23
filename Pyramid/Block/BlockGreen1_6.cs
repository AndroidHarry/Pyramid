using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockGreen1_6 : Block
    {
        public BlockGreen1_6() : base(6, 5)
        {
            FlatShapes = new Point[8, 5] {
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

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 * 可能还有别的摆法 TBD
                 */
                new Point[]
                {
                    // 0
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3)
                },
                new Point[]
                {
                    // 1
                    new Point(3, 0, 0),
                    new Point(2, 1, 0),
                    new Point(2, 0, 1),
                    new Point(1, 0, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 2
                    new Point(1, 2, 0),
                    new Point(0, 3, 0),
                    new Point(0, 2, 1),
                    new Point(0, 1, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 3
                    new Point(2, 2, 0),
                    new Point(3, 3, 0),
                    new Point(2, 2, 1),
                    new Point(1, 1, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 4
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3)
                },
                new Point[]
                {
                    // 5
                    new Point(3, 0, 0),
                    new Point(2, 0, 1),
                    new Point(1, 1, 1),
                    new Point(1, 0, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 6
                    new Point(0, 3, 0),
                    new Point(3, 3, 1),
                    new Point(1, 1, 1),
                    new Point(0, 1, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 7
                    new Point(3, 3, 0),
                    new Point(1, 1, 1),
                    new Point(2, 2, 1),
                    new Point(1, 1, 2),
                    new Point(0, 0, 3),
                }
            };
        }
    }
}
