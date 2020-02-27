using Pyramid.Block;
using Pyramid.Ground;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public abstract class Exercise
    {
        protected Block.IBlock[] blocks = null;

        protected IGround ground = null;

        private ExecSet execSet = new ExecSet();


        public abstract bool Init();

        protected bool InitPutBlock(int layer)
        {
            Random random = new Random();
            int i = random.Next(execSet.GetInitBlockCount(layer));

            //for (int j = 0; j < 10; ++j)
            //{
            //    i = random.Next(execSet.GetInitBlockCount(layer));
            //    Console.Write("{0,3}", i);
            //}
            
            InitBlock[] b = execSet.GetInitBlock(layer, i);
            if (b != null)
            {
                return InitPutBlock(b);
            }
            else
            {
                return false;
            }
        }

        private bool InitPutBlock(InitBlock initBlock)
        {
            IBlock block = GetBlockByValue(initBlock.value);
            if (block != null)
            {
                if (block.CanFit(initBlock.points))
                {
                    ground.Fill(initBlock.points, block.value);
                    blocks = blocks.CreateBlocksExcludeIndex(block);
                    return true;
                }
            }
            return false;
        }

        private bool InitPutBlock(InitBlock[] initBlock)
        {
            for (int i = 0; i < initBlock.Length; ++i)
            {
                if (!InitPutBlock(initBlock[i]))
                {
                    return false;
                }
            }
            return true;
        }


        public void Start()
        {
            if (ground != null && blocks != null)
            {
                Console.WriteLine($"start:  {DateTime.Now.ToString("HH:mm:ss.fff")}");
                ground.Start(blocks);
                Console.WriteLine($"end:  {DateTime.Now.ToString("HH:mm:ss.fff")}");
            }
        }

        public Block.IBlock GetBlockByValue(int value)
        {
            if (blocks == null || blocks.Length < 1)
            {
                return null;
            }

            for (int i = 0; i < blocks.Length; ++i)
            {
                if (blocks[i].value == value)
                {
                    return blocks[i];
                }
            }

            return null;
        }

        protected Block.IBlock[] CreateAll(bool bZAsc)
        {
            Block.IBlock[] blocks = new Block.IBlock[] {
                new BlockPink2_4(bZAsc),
                new BlockRed1_1(bZAsc), new BlockRed2_2(bZAsc),
                new BlockPurple_5(bZAsc),
                new BlockGreen1_6(bZAsc),
                new BlockGreen2_7(bZAsc),
                new BlockBlue1_8(bZAsc), new BlockBlue2_9(bZAsc),
                new BlockYellow_10(bZAsc),
                new BlockGrey_11(bZAsc),
                new BlockPink1_3(bZAsc),
                new BlockWhite_12(bZAsc)
            };

            return blocks;
        }
    }
}
