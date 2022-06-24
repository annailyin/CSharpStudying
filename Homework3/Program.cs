using System;

namespace CSharpStudyingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            for (int i = 0; i < 5; i++)
            {
                points[i] = new Point(i + 0.555m, i + 0.777m);
                Console.WriteLine(points[i]);
            }
            //Adding points
            Point point = points[0] + points[1];
            Console.WriteLine("The result of adding the 1st and the 2nd points: ");
            Console.WriteLine(point);
        }
    }
}
