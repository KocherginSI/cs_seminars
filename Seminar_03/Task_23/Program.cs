using System;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            CubicTable(number);


        }

        static void CubicTable(int number)
        {
            for (int i = 1;  i <= number; i++)
            {
                double result = Math.Pow(i, 3);
                System.Console.Write($"{result} ");
            }
        }
    }

}
