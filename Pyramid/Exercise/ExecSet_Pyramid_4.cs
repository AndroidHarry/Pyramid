using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        private InitBlock[][] blockGroups_4 =
            new InitBlock[][] {
                //  0 #371
                new InitBlock[] {
                    new InitBlock()
                    {
                        value = 4,
                        points = new Point[] {
                        new Point(2,0,0),
                        new Point(3,0,0),
                        new Point(3,1,0),
                        new Point(3,2,0),
                        new Point(3,3,0)
                    }
                    },
                    new InitBlock()
                    {
                        value = 8,
                        points = new Point[] {
                        new Point(2,1,0),
                        new Point(2,2,0),
                        new Point(2,3,0),
                        new Point(1,3,0),
                        new Point(0,3,0)
                    }
                    },
                },

                //  1 #375
                new InitBlock[] {
                    new InitBlock()
                    {
                        value = 12,
                        points = new Point[] {
                        new Point(1,1,0),
                        new Point(1,2,0),
                        new Point(2,2,0),
                        new Point(3,2,0),
                        new Point(3,1,0)
                    }
                    },
                    new InitBlock()
                    {
                        value = 8,
                        points = new Point[] {
                        new Point(0,1,0),
                        new Point(0,2,0),
                        new Point(0,3,0),
                        new Point(1,3,0),
                        new Point(2,3,0)
                    }
                    },
                }
            };
    }
}
