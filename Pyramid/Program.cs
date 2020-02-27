using Pyramid.Block;
using Pyramid.Exercise;
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

            // DoTriangleGround();

            DoPyramidGround(5);

            Console.Read();
        }

        static void Test()
        {
        }

        static void DoPyramidGround(int layer)
        {
            Exercise.Exercise exercise = new PyramidExercise(layer);
            exercise.Init();
            exercise.Start();
        }

        static void DoTriangleGround()
        {
            Exercise.Exercise exercise = new TriangleExercise();
            exercise.Init();
            exercise.Start();
        }
    }
}
