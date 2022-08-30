using System;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите координаты первой точки (x, y, z):");
            double firstX = Convert.ToDouble(Console.ReadLine());
            double firstY = Convert.ToDouble(Console.ReadLine());
            double firstZ = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Введите координаты второй точки (x, y, z):");
            double secondX = Convert.ToDouble(Console.ReadLine());
            double secondY = Convert.ToDouble(Console.ReadLine());
            double secondZ = Convert.ToDouble(Console.ReadLine());


            Distance(firstX, firstY, firstZ, secondX, secondY, secondZ);

        }


        static void Distance(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ)
        {
            double distance = Math.Sqrt((Math.Pow(secondX - firstX, 2)) + (Math.Pow(secondY - firstY, 2)) + (Math.Pow(secondZ - firstZ, 2)));
            System.Console.WriteLine($"distance: {distance:f2}");
        }

    }
}

