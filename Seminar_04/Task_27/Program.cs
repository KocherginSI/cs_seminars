// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

namespace Task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = SummOfDigits(number);
            System.Console.WriteLine($"Сумма цифр числа {number} равна: {result}");
        

        }

        static int SummOfDigits(int number)
        {
            int summ = 0;
            while (number != 0)
            {
                summ += number % 10;
                number /= 10;
            }
            return summ;
        }
    }
}