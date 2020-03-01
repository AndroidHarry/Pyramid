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
            Exercise.Exercise exercise = null;

            Console.WriteLine("Please select game:");
            Console.WriteLine("1) Triangle Exercise");
            Console.WriteLine("4) Pyramid Layer-4 Exercise");
            Console.WriteLine("5) Pyramid Layer-5 Exercise");
            Console.WriteLine("x) Exit");

            string title;
            string line;

            while (true)
            {
                line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        exercise = new TriangleExercise();
                        title = Exercise.Exercise.GetExerciseTitles(1);
                        Console.WriteLine($"Triangle Exercises: {title}");
                        line = Console.ReadLine();
                        exercise.Init(line);
                        exercise.Start();
                        break;

                    case "4":
                        exercise = new PyramidExercise(4);
                        title = Exercise.Exercise.GetExerciseTitles(4);
                        Console.WriteLine($"Pyramid Layer-4 Exercises: {title}");
                        line = Console.ReadLine();
                        exercise.Init(line);
                        exercise.Start();
                        break;

                    case "5":
                        exercise = new PyramidExercise(5);
                        title = Exercise.Exercise.GetExerciseTitles(5);
                        Console.WriteLine($"Pyramid Layer-5 Exercises: {title}");
                        line = Console.ReadLine();
                        exercise.Init(line);
                        exercise.Start();
                        break;

                    case "x":
                        Console.WriteLine("88");
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please input 1, 4 or 5 to select exercise, x to exit.");
                        break;
                }
            }
        }
    }
}
