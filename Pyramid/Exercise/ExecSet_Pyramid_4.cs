using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        private ExerciseInfo[] blockGroups_4 =
            
            new ExerciseInfo[] {

                new ExerciseInfo {
                    title = "371",
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 4,
                            points = new Point[] {
                                new Point(2,0,0),
                                new Point(3,0,0),
                                new Point(3,1,0),
                                new Point(3,2,0),
                                new Point(3,3,0)
                            }
                        },
                        new InitBlockInfo() {
                            value = 8,
                            points = new Point[] {
                                new Point(2,1,0),
                                new Point(2,2,0),
                                new Point(2,3,0),
                                new Point(1,3,0),
                                new Point(0,3,0)
                            }
                        },
                    }
                },

                new ExerciseInfo {
                    title = "375",
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 12,
                            points = new Point[] {
                                new Point(1,1,0),
                                new Point(1,2,0),
                                new Point(2,2,0),
                                new Point(3,2,0),
                                new Point(3,1,0)
                            }
                        },
                        new InitBlockInfo() {
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
                }, 
            };
    }
}
