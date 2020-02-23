using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue2_9 : Block
    {
        public BlockBlue2_9() : base(9, 5)
        {
            FlatShapes = new Point[8, 5] {
                {
                    /* 0
                     *    9 9
                     *    9 9 9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 1
                     *    9 9
                     *  9 9 9 
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(-1, 1)
                },
                {
                    /* 2
                     *    9 9 9
                     *    9 9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(1, 1)
                },
                {
                    /* 3
                     *    9 9 9
                     *      9 9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 4
                     *   9 
                     *   9 9
                     *   9 9
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(0, 2),
                    new Point(1, 2)
                },
                {
                    /* 5
                     *     9
                     *   9 9
                     *   9 9
                     */
                    new Point(0, 0),
                    new Point(0, 1),
                    new Point(-1, 1),
                    new Point(0, 2),
                    new Point(-1, 2)
                },
                {
                    /* 6
                     *     9 9 
                     *     9 9
                     *     9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(0, 2)
                },
                {
                    /* 7
                     *     9 9
                     *     9 9
                     *       9
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(1, 2)
                }
            };

            Shape3D = new Point[][] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 * 有 8*2=16 种 , TBD
                 */
                new Point[]
                {
                    // 0
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(1, 1, 1),
                    new Point(0, 0, 2),
                    new Point(0, 0, 3),
                },
                new Point[]
                {
                    // 1
                    new Point(3, 1, 0),
                    new Point(3, 0, 1),
                    new Point(2, 1, 1),
                    new Point(2, 0, 2),
                    new Point(1, 0, 3),
                },
            };
        }
    }
}
