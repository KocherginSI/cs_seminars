using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
            System.Console.WriteLine("6 -> да");
            System.Console.WriteLine("7 -> да");
            System.Console.WriteLine("1 -> нет");
            
            System.Console.WriteLine("Введите цифру, обозначающую день недели:");
            int userDay = Convert.ToInt32(Console.ReadLine());

            DayOfTheWeek(userDay);
        }

        static void DayOfTheWeek(int dayNumber)
        {
            if (dayNumber == 6 | dayNumber == 7)
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




