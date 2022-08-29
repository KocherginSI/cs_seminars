using System;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите координаты первой точки (x, y):");
            double firstX = Convert.ToDouble(Console.ReadLine());
            double firstY = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Введите координаты второй точки (x, y):");
            double secondX = Convert.ToDouble(Console.ReadLine());
            double secondY = Convert.ToDouble(Console.ReadLine());

            Distance(firstX, firstY, secondX, secondY);            

        }


        static void Distance(double firstX, double firstY, double secondX, double secondY)
        {
            double distance = Math.Sqrt((Math.Pow(secondX - firstX, 2) + (Math.Pow(secondY - firstY, 2))));
            System.Console.WriteLine($"distance: {distance}");
        }

    }
}

