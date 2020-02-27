using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        private InitBlock[][] blockGroups_1 =
            new InitBlock[][] {
                //  0 #1
                new InitBlock[] {
                    new InitBlock()
                    {
                        value = 10,
                        points = new Point[] {
                        new Point(0,4,0),
                        new Point(1,4,0),
                        new Point(0,5,0),
                        new Point(1,5,0),
                    }
                    },
                }, 

                //  1 #7
                new InitBlock[] {
                    new InitBlock()
                    {
                        value = 8,
                        points = new Point[] {
                        new Point(0,2,0),
                        new Point(0,3,0),
                        new Point(0,4,0),
                        new Point(1,4,0),
                        new Point(2,4,0),
                    }
                    },
                    new InitBlock()
                    {
                        value = 10,
                        points = new Point[] {
                        new Point(3,7,0),
                        new Point(4,7,0),
                        new Point(3,8,0),
                        new Point(4,8,0),
                    }
                    },
                },
            };
    }
}
