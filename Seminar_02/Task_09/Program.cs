using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }

        static int MaxNumber()
        {
            int number1 = new Random().Next(10, 1000);
            int max = 0;
            int iterator = number1;

            while (iterator != 0)
            {
                int number2 = iterator % 10;

                if (number2 > max) max = number2;

                iterator /= 10;

            }
        }
    }

}