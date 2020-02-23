using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockRed1_1 : Block
    {
        public BlockRed1_1() : base(1, 5)
        {
            FlatShapes = new Point[1, 5] {
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

            /*
             * 与底面垂直站立放置
             */
            Shape3D = new Point[][] {
                new Point[]
                {
                    new Point(2, 1, 0),
                    new Point(1, 2, 0),
                    new Point(1, 1, 1),
                    new Point(1, 0, 2),
                    new Point(0, 1, 2),
                },
                new Point[]
                {
                    //  1
                    new Point(2, 1, 0),
                    new Point(3, 2, 0),
                    new Point(2, 1, 1),
                    new Point(1, 0, 2),
                    new Point(2, 1, 2),
                }
            };
        }
    }
}
