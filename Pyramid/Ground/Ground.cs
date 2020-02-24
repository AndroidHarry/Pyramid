using Pyramid.Block;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Ground
{
    public abstract class IGround
    {
        public abstract void Init();

        public abstract bool SuccessFlag();

        public abstract bool CanFill(Point point);

        public bool CanFill(Point[] points)
        {
            foreach (Point point in points)
            {
                if (!CanFill(point))
                    return false;
            }

            return true;
        }

        public abstract void Fill(Point[] points, int v);

        public abstract bool FillBlock(Block.Block[] blocks, Point point);

        public abstract void Print();

        public bool CanContinue()
        {
            if (!bContinue)
                return false;

            Console.WriteLine("Press Enter to Continue, other key to Exit ");

            string key = Console.ReadKey().Key.ToString();
            if (key == "Enter")
            {
                bContinue = true;
            }
            else
            {
                bContinue = false;
            }

            Console.WriteLine();

            return bContinue;
        }

        protected bool bContinue = true;

        protected int successCount = 0;
    }
}
