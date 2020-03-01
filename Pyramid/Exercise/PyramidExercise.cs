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


        public override bool Init(string title)
        {
            ground.Init();

            if (InitPutBlock(layerNum, title))
            {
                prompt = $"Pyramid Layer-{layerNum} Exercise '{title}'";
                ground.Print($"Init for {prompt} success:");

                return true;
            }

            prompt = $"Pyramid Layer-{layerNum} Exercise";
            ground.Print($"Init for {prompt} fail:");
            return false;
        }
    }
}
