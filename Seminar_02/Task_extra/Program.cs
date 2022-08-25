using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
            System.Console.WriteLine("14 -> нет");
            System.Console.WriteLine("46 -> нет");
            System.Console.WriteLine("161 -> да");
            System.Console.WriteLine();

            System.Console.Write("Введите число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            NumberCheck(userNumber);

        }

        static void NumberCheck(int number)
        {
            if ((number % 7 == 0) & (number % 23 == 0))
            {
                System.Console.WriteLine("-> да");

            }
            else
            {
                System.Console.WriteLine("-> нет");

            }

        }

    }
}

