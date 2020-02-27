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

        public override bool Init()
        {
            Console.WriteLine("Init:");

            ground.Init();

            if (InitPutBlock(1))
            {
                ground.Print();

                return true;
            }

            return false;
        }
    }
}
