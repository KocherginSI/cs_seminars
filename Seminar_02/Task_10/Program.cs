using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
            System.Console.WriteLine("456 -> 5");
            System.Console.WriteLine("782 -> 8"); 
            System.Console.WriteLine("918 -> 1");
            System.Console.WriteLine();
            SecondDigit();
        }
    
        static void SecondDigit()
        {
            int number = new Random() .Next(100, 1000);
            int secondDigit = number;
            secondDigit %= 100;
            secondDigit /= 10; 

            System.Console.WriteLine($"Случайное трехзначное число: {number}");
            System.Console.WriteLine($"Вторая цифра числа: {secondDigit}");
        }
    
    }
}