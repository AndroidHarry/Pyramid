using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public class BlockWhite_12 : Block
    {
        public BlockWhite_12() : base(12, 5)
        {
            FlatShapes = new Point[4, 5] {
                {
                    /* 0
                     *     12 12 12
                     *     12    12
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(2, 1)
                },
                {
                    /* 1
                     *      12    12
                     *      12 12 12
                     */
                    new Point(0, 0),
                    new Point(2, 0),
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1)
                },
                {
                    /* 2
                     *     12 12
                     *     12
                     *     12 12
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(0, 1),
                    new Point(0, 2),
                    new Point(1, 2)
                },
                {
                    /* 3
                     *     12 12
                     *        12
                     *     12 12
                     */
                    new Point(0, 0),
                    new Point(1, 0),
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(0, 2)
                }
            };

            Shape3D = null;    //  TBD
        }
    }
}
