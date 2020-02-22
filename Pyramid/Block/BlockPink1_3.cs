using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockPink1_3 : IBlock
    {
        public int Value { get => 3; }

        public int UnitNum { get => 3; }

        public Point[,] FlatShapes
        {
            get => new Point[4, 3] {
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
        }

        public Point[,] Shape3Ds
        {
            get => new Point[6, 3] {
                /*
                 * 与底面垂直站立放置
                 * TBD 还有摆放方式
                 */
                {
                    /* 0
                     *    (1, 0, 0)
                     *    (0, 1, 0)
                     *    (0, 0, 1)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-1, 0, 1)
                },
                {
                    /* 1
                     *     (0, 0, 0)
                     *     (1, 1, 0)
                     *     (0, 0, 1)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1)
                },
                {
                    /* 2
                     *     (1, 1, 0)
                     *     (0, 0, 1)
                     *     (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, -1, 1),
                    new Point(-1, -1, 2)
                },
                {
                    /* 3
                     *     (1, 1, 0)
                     *     (1, 0, 1)
                     *     (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(0, -1, 1),
                    new Point(-1, -1, 2)
                },
                {
                    /* 4
                     *     (1, 1, 0)
                     *     (0, 1, 1)
                     *     (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 0, 1),
                    new Point(-1, -1, 2)
                },
                {
                    /* 5
                     *     (1, 1, 0)
                     *     (1, 1, 1)
                     *     (0, 0, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(0, 0, 1),
                    new Point(-1, -1, 2)
                }
            };
        }
    }
}
