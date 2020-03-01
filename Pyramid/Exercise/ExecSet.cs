using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        public string GetExerciseTitles(int layer)
        {
            ExerciseInfo[] b = GetInitBlockGroup(layer);

            if (b != null && b.Length > 0)
            {
                string t = "";
                foreach (ExerciseInfo ei in b)
                {
                    t += $"'{ei.title}' ";
                }

                return t;
            }

            return "";
        }

        public ExerciseInfo GetInitBlock(int layer, string title)
        {
            ExerciseInfo[] b = GetInitBlockGroup(layer);
            if (b != null)
            {
                foreach (var ei in b)
                {
                    if (ei.title == title)
                    {
                        return ei;
                    }
                }
            }

            return null;
        }

        public InitBlockInfo[] GetInitBlock(int layer, int index)
        {
            ExerciseInfo[] b = GetInitBlockGroup(layer);
            if (b != null &&
                0 <= index && index < b.Length)
            {
                return b[index].infos;
            }

            return null;
        }

        public int GetInitBlockCount(int layer)
        {
            ExerciseInfo[] b = GetInitBlockGroup(layer);
            return (b != null) ? b.Length : 0;
        }

        private ExerciseInfo[] GetInitBlockGroup(int layer)
        {
            ExerciseInfo[] b = null;

            switch (layer)
            {
                case 1:
                    b = blockGroups_1;
                    break;
                case 4:
                    b = blockGroups_4;
                    break;
                case 5:
                    b = blockGroups_5;
                    break;
            }

            return b;
        }
    }
}
