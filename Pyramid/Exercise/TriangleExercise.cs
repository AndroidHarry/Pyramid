using Pyramid.Block;
using Pyramid.Ground;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Exercise
{
    public class TriangleExercise : Exercise
    {
        public TriangleExercise()
        {
            blocks = CreateAll(true);

            ground = new TriangleGround();
        }

        public override bool Init(string title)
        {
            ground.Init();


            if (InitPutBlock(1, title))
            {
                prompt = $"Triangle Exercise '{title}'";
                ground.Print($"Init for {prompt} success:");

                return true;
            }

            prompt = $"Triangle Exercise";
            ground.Print($"Init for {prompt} fail:");
            return false;
        }
    }
}
