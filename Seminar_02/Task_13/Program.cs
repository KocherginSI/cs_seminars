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
            ThirdNumber();
        }

        static int ThirdNumber()
        {
            System.Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.Read());
            int[] array = {};
            int thirdNumber = 0;
            int lastDigit = 0;

            while (number >= 10)
            {
                lastDigit = number % 10;
                array = new int[lastDigit];
                number -= lastDigit;

            }
            
            Console.WriteLine($"Length: {array.Length}");
            foreach (int item in array) Console.WriteLine(item);


            if (array.Length < 2)
            {
                System.Console.WriteLine($"-> Третьей цифры нет.");
            }
            else
            {
                thirdNumber = array[1];
                System.Console.WriteLine($"-> {thirdNumber}");
            }

            return thirdNumber;

        }
    }
}