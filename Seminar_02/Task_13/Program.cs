using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
            System.Console.WriteLine("645 -> 5");
            System.Console.WriteLine("78 -> третьей цифры нет");
            System.Console.WriteLine("32679 -> 6");
            System.Console.WriteLine();
            
            System.Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            ThirdNumber(number);
        }

        static void ThirdNumber(int number)
        {
            
            int numberTemp = number;
            int digitCounter = 0;
            int lastDigit = 0;
            int thirdNumber = 0;

            while (numberTemp > 0)
            {
                lastDigit = numberTemp % 10;
                digitCounter++;
                numberTemp /= 10;
            }

            if (digitCounter < 3)
            {
                System.Console.WriteLine($"-> Третьей цифры нет.");
            }
            else
            {
                while (digitCounter >= 3)
                {
                    thirdNumber = number % 10;
                    number /= 10;
                    --digitCounter;

                }
                System.Console.WriteLine($"thirdNumber -> {thirdNumber}");
            }
        }
    }
}