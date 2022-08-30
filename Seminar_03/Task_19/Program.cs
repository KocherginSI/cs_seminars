// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;

namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Введите пятизначное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            isPolindrom(number);

        }


        static void isPolindrom(int number)
        {

            int leftSideNumber = number / 1000;

            number %= 100;

            int rightDigitsNumber = number % 10 * 10;

            rightDigitsNumber += number / 10;
    
            
           if (leftSideNumber != rightDigitsNumber)
           {
                System.Console.WriteLine("Введенное число не является полиндромом.");
           }
           else
           {
                System.Console.WriteLine("Введенное число является полиндромом.");
           }

        }

    }
}
