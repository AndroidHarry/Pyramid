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

        protected string prompt = "";

        private static ExecSet execSet = new ExecSet();


        public static string GetExerciseTitles(int layer)
        {
            return execSet.GetExerciseTitles(layer);
        }

        public abstract bool Init(string title);

        protected bool InitPutBlock(int layer, string title)
        {
            //Random random = new Random();
            //int i = random.Next(execSet.GetInitBlockCount(layer));

            //for (int j = 0; j < 10; ++j)
            //{
            //    i = random.Next(execSet.GetInitBlockCount(layer));
            //    Console.Write("{0,3}", i);
            //}

            ExerciseInfo i = execSet.GetInitBlock(layer, title);
            if (i != null)
            {
                if (i.spInfo != null)
                {
                    return InitPutBlockSp(i.spInfo) && InitPutBlock(i.infos);
                }
                else
                {
                    return InitPutBlock(i.infos);
                }
            }
            else
            {
                return false;
            }
        }

        private bool InitPutBlock(InitBlockInfo initBlock)
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

        private bool InitPutBlock(InitBlockInfo[] initBlock)
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

        private bool InitPutBlockSp(InitBlockInfo initBlock)
        {
            ground.SetInitBlockInfoSp(initBlock);
            return true;
        }


        public void Start()
        {
            if (ground != null && blocks != null)
            {
                Console.WriteLine($"computing {prompt} ...");
                ground.Start(blocks, prompt);
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
