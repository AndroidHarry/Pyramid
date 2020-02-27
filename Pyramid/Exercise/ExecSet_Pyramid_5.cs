using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        private InitBlock[][] blockGroups_5 =
            new InitBlock[][] {
                //  0 #419
                new InitBlock[] {
                    new InitBlock()
                    {
                        value = 1,
                        points = new Point[] {
                        new Point(3,1,0),
                        new Point(3,2,0),
                        new Point(3,3,0),
                        new Point(2,2,0),
                        new Point(4,2,0)
                    }
                    },
                    new InitBlock()
                    {
                        value = 10,
                        points = new Point[] {
                        new Point(0,0,0),
                        new Point(0,1,0),
                        new Point(1,0,0),
                        new Point(1,1,0),
                    }
                    },
                },

                //  1 #421
                new InitBlock[] {
                    new InitBlock()
                    {
                        value = 1,
                        points = new Point[] {
                        new Point(1,1,0),
                        new Point(1,2,0),
                        new Point(1,3,0),
                        new Point(0,2,0),
                        new Point(2,2,0)
                    }
                    },
                    new InitBlock()
                    {
                        value = 7,
                        points = new Point[] {
                        new Point(4,1,0),
                        new Point(4,2,0),
                        new Point(4,3,0),
                        new Point(4,4,0),
                    }
                    },
                },
            };
    }
}
