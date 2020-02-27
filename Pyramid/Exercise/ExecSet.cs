using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public partial class ExecSet
    {
        public InitBlock[] GetInitBlock(int layer, int index)
        {
            InitBlock[][] b = GetInitBlockGroup(layer);
            if (b != null &&
                0 <= index && index < b.Length)
            {
                return b[index];
            }

            return null;
        }

        public int GetInitBlockCount(int layer)
        {
            InitBlock[][] b = GetInitBlockGroup(layer);
            return (b != null) ? b.Length : 0;
        }

        private InitBlock[][] GetInitBlockGroup(int layer)
        {
            InitBlock[][] b = null;

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
