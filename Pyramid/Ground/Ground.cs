using Pyramid.Block;
using Pyramid.Exercise;
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

        protected abstract bool FillBlock(Block.IBlock[] blocks, Point point);

        public abstract void Print(string title);

        public bool CanContinue()
        {
            if (!bContinue)
                return false;

            Console.WriteLine("Press Enter to Continue, other key to Return ");

            string key = Console.ReadKey().Key.ToString();
            if (key == "Enter")
            {
                bContinue = true;
                Console.WriteLine($"computing {prompt} ...");
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

        protected Timer timer = new Timer();

        protected Point startPoint = new Point(0, 0);

        protected string prompt;

        //  特殊放置点
        protected InitBlockInfo initBlockSp;

        public void SetInitBlockInfoSp(InitBlockInfo initBlockSp)
        {
            this.initBlockSp = initBlockSp;
        }

        public void Start(Block.IBlock[] blocks, string prompt)
        {
            this.prompt = prompt;

            timer.Start();

            FillBlock(blocks, startPoint);

            Console.WriteLine("end");
        }
    }
}
