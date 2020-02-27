using Pyramid.Block;
using Pyramid.Ground;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public class PyramidExercise : Exercise
    {
        private bool bZAsc = false;

        private readonly int layerNum;


        public PyramidExercise(int layerNum)
        {
            this.layerNum = layerNum;

            blocks = CreateAll(bZAsc);

            ground = new PyramidGround(layerNum, bZAsc);
        }


        public override bool Init()
        {
            Console.WriteLine("Init:");

            ground.Init();

            if (InitPutBlock(layerNum))
            {
                ground.Print();

                return true;
            }

            return false;
        }
    }
}
