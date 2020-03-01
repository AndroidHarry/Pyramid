using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        private ExerciseInfo[] blockGroups_5 =
            
            new ExerciseInfo[] {

                new ExerciseInfo {
                    title = "478", 
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 9,
                            points = new Point[] {
                                new Point(0,0,0),
                                new Point(0,1,0),
                                new Point(1,0,0),
                                new Point(1,1,0),
                                new Point(2,0,0),
                            }
                        }
                    }
                },

                new ExerciseInfo {
                    title = "419",
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 1,
                            points = new Point[] {
                                new Point(3,1,0),
                                new Point(3,2,0),
                                new Point(3,3,0),
                                new Point(2,2,0),
                                new Point(4,2,0)
                            }
                        },
                        new InitBlockInfo() {
                            value = 10,
                            points = new Point[] {
                                new Point(0,0,0),
                                new Point(0,1,0),
                                new Point(1,0,0),
                                new Point(1,1,0),
                            }
                        },
                    }
                },

                new ExerciseInfo {
                    title = "421",
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 1,
                            points = new Point[] {
                                new Point(1,1,0),
                                new Point(1,2,0),
                                new Point(1,3,0),
                                new Point(0,2,0),
                                new Point(2,2,0)
                            }
                        },
                        new InitBlockInfo() {
                            value = 7,
                            points = new Point[] {
                                new Point(4,1,0),
                                new Point(4,2,0),
                                new Point(4,3,0),
                                new Point(4,4,0),
                            }
                        },
                    }
                }
            };
    }
}
