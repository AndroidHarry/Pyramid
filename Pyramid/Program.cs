using Pyramid.Block;
using Pyramid.Ground;
using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //Console.Read();
            //return;

            //DoTriangleGround();

            DoPyramidGround();

            Console.Read();
        }

        static void Test()
        {
            

            Region.Test();
        }

        static void DoPyramidGround()
        {
            bool bZAsc = false;
            int layerNum = 5;    // 5

            Block.Block[] blocks = BlockGroup.CreateAll(bZAsc);

            Console.WriteLine("Init:");

            IGround g = new PyramidGround(layerNum, bZAsc);
            g.Init();
            g.Print();

            if (true)
            {
                #region place init block(s)
                ////  one block 
                //int value = 10;
                //int bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(0, new Point(0, 0));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 12;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(0, new Point(2, 0));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 9;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.Shape3D(1, new Point(3, 1));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 5;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(0, new Point(0, 2));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 11;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(3, new Point(2, 2));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 4;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(0, new Point(0, 3));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 7;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.Shape3D(3, new Point(4, 4));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 8;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(2, new Point(0, 0, 1));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 3;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.Shape3D(2, new Point(1, 1, 1));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 2;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.ShapeFlat(1, new Point(3, 1, 1));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                ////  another block
                //value = 6;
                //bi = blocks.GetBlockIndexByValue(value);
                //if (bi >= 0)
                //{
                //    IBlock block = blocks[bi];

                //    Point[] pts = block.Shape3D(2, new Point(1, 2, 1));
                //    g.Fill(pts, value);

                //    blocks = blocks.CreateBlocksExcludeIndex(bi);
                //}
                #endregion
            }

            g.Print();

            //return;

            Console.WriteLine($"start:  {DateTime.Now.ToString("HH:mm:ss.fff")}");


            g.FillBlock(blocks, bZAsc ? new Point(0, 0, 0) : new Point(0, 0, layerNum - 1));

            g.Print();

            Console.WriteLine($"end:  {DateTime.Now.ToString("HH:mm:ss.fff")}");
        }

        static void DoTriangleGround()
        {
            Console.WriteLine("Init:");

            Block.Block[] blocks = BlockGroup.CreateAll(true);

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
                    Block.Block block = blocks[bi];

                    Point[] pts = block.MoveShapeFlat(6, new Point(0, 6));
                    g.Fill(pts, value);

                    blocks = blocks.CreateBlocksExcludeIndex(bi);
                }
                //  another block
                value = 9;
                bi = blocks.GetBlockIndexByValue(value);
                if (bi >= 0)
                {
                    Block.Block block = blocks[bi];

                    Point[] pts = block.MoveShapeFlat(1, new Point(2, 8));
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
