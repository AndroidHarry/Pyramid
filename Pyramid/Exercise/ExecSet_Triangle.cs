using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        private ExerciseInfo[] blockGroups_1 =

            new ExerciseInfo[] {

                new ExerciseInfo {
                    title = "1",
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 10,
                            points = new Point[] {
                                new Point(0,4,0),
                                new Point(1,4,0),
                                new Point(0,5,0),
                                new Point(1,5,0),
                            }
                        },
                    },
                },

                new ExerciseInfo {
                    title = "7",
                    infos = new InitBlockInfo[]
                    {
                        new InitBlockInfo() {
                            value = 8,
                            points = new Point[] {
                                new Point(0,2,0),
                                new Point(0,3,0),
                                new Point(0,4,0),
                                new Point(1,4,0),
                                new Point(2,4,0),
                            }
                        },
                        new InitBlockInfo() {
                            value = 10,
                            points = new Point[] {
                                new Point(3,7,0),
                                new Point(4,7,0),
                                new Point(3,8,0),
                                new Point(4,8,0),
                            }
                        },
                    }
                }
            };
    }
}
