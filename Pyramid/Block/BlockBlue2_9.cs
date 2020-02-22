using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockBlue2_9 : IBlock
    {
        public int Value { get => 9; }

        public int UnitNum { get => 5; }

        public Point[,] FlatShapes
        {
            get => new Point[8, 5] {
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
        }

        public Point[,] Shape3Ds
        {
            get => new Point[2, 5] {
                /*
                 * 与底面垂直站立放置
                 * 长边与底面成 45 度角
                 * 有 8*2=16 种 , TBD
                 */
                {
                    /* 0
                     *    (1, 1, 0)
                     *    (0, 0, 1)
                     *    (1, 1, 1)
                     *    (0, 0, 2)
                     *    (0, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(-1, -1, 1),
                    new Point(0, 0, 1),
                    new Point(-1, -1, 2),
                    new Point(-1, -1, 3)
                },
                {
                    /* 1
                     *     (3, 1, 0)
                     *     (3, 0, 1)
                     *     (2, 1, 1)
                     *     (2, 0, 2)
                     *     (1, 0, 3)
                     */
                    new Point(0, 0, 0),
                    new Point(0, -1, 1),
                    new Point(-1, 0, 1),
                    new Point(-1, -1, 2),
                    new Point(-2, -1, 3)
                },
            };
        }
    }
}
