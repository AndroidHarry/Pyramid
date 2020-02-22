using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed1_1 : IBlock
    {
        public int Value{ get => 1; }

        public int UnitNum{ get => 5; }

        public Point[,] FlatShapes {
            get => new Point[1,5] {
                {
                    /* 0
                     *    1
                     *  1 1 1 
                     *    1
                     */
                    new Point(0, 0),
                    new Point(-1, 1),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(0, 2)
                },
            };
        }

        public Point[,] Shape3Ds {
            get => new Point[2, 5] {
                /*
                 * 与底面垂直站立放置
                 */
                {
                    /* 0
                     *    (2, 1, 0)
                     *    (1, 2, 0)
                     *    (1, 1, 1)
                     *    (1, 0, 2)
                     *    (0, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, 1, 0),
                    new Point(-1, 0, 1),
                    new Point(-1, -1, 2),
                    new Point(-2, 0, 2)
                },
                {
                    /* 1
                     *     (2, 1, 0)
                     *     (3, 2, 0)
                     *     (2, 1, 1)
                     *     (1, 0, 2)
                     *     (2, 1, 2)
                     */
                    new Point(0, 0, 0),
                    new Point(1, 1, 0),
                    new Point(0, 0, 1),
                    new Point(-1, -1, 2),
                    new Point(0, 0, 2)
                },
            };
        }
    }
}
