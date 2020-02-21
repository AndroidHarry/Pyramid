using Pyramid.Block;
using Pyramid.Ground;
using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Do();

            Console.Read();
        }

        static void Do()
        {
            Console.WriteLine("Init:");

            IBlock[] blocks = new IBlock[] {
                new BlockPink2_4(),
                new BlockRed1_1(), new BlockRed2_2(),
                new BlockPurple_5(),
                new BlockGreen1_6(),
                new BlockGreen2_7(),
                new BlockBlue1_8(), new BlockBlue2_9(),
                new BlockYellow_10(),
                new BlockGrey_11(),
                new BlockPink1_3(),
                new BlockWhite_12()
            };

            IGround g = new TriangleGround();
            g.Init();

            if (false)
            {
                #region place init block(s)
                //  one block 
                int value = 6;
                int bi = blocks.GetBlockIndexByValue(value);
                if (bi >= 0)
                {
                    IBlock block = blocks[bi];

                    Point[] pts = block.Shape(6, new Point(0, 6));
                    g.Fill(pts, value);

                    blocks = blocks.CreateBlocksExcludeIndex(bi);
                }
                //  another block
                value = 9;
                bi = blocks.GetBlockIndexByValue(value);
                if (bi >= 0)
                {
                    IBlock block = blocks[bi];

                    Point[] pts = block.Shape(1, new Point(2, 8));
                    g.Fill(pts, value);

                    blocks = blocks.CreateBlocksExcludeIndex(bi);
                }
                #endregion
            }

            g.Print();

            

            Console.WriteLine($"start:  {DateTime.Now.ToString("HH:mm:ss.fff")}");

            g.FillBlock(blocks, new Point(0, 0));

            g.Print();

            Console.WriteLine($"end:  {DateTime.Now.ToString("HH:mm:ss.fff")}");
        }
    }
}
