using System;
using System.Linq;

namespace Lab2PointInRectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] coordinats = InputParse();

            Point topLeft = new Point(coordinats[0], coordinats[1]);
            Point bottomRight = new Point(coordinats[2], coordinats[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int numberOfPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPoints; i++)
            {
                int[] point = InputParse();

                Point pointToCheck = new Point(point[0], point[1]);

                Console.WriteLine(rectangle.Contains(pointToCheck));
            }

        }

        private static int[] InputParse()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
