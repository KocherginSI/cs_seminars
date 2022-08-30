// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

namespace Task_25
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число A:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите число B:");
            int numberB = Convert.ToInt32(Console.ReadLine());

            
            double exponent = Exponent(numberA, numberB);
            System.Console.WriteLine($"{numberA} ^ {numberB} -> {exponent}");
            
        }

        static double Exponent(int numberA, int numberB)
        {
        
            double result = numberA;
            for (int i = 1; i < numberB; i++)
            {   
                result *= numberA;

            }

            return result;
        }
         
    }
}