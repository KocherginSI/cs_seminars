// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите количество элементов массива:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Введите минимальный элемент массива:");
            int arrayMin = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Введите максимальный элемент массива:");
            int arrayMax = Convert.ToInt32(Console.ReadLine());

            ArrayMinMax(arrayLength, arrayMin, arrayMax);
        }

        static void ArrayMinMax(int arrayLength, int arrayMin, int arrayMax)
        {
            int[] userArray = new int[arrayLength];
            for (int i = 1; i < arrayLength; i++)
            {
                userArray[i] = new Random() .Next(arrayMin, arrayMax);
                
                System.Console.Write($"{userArray[i]} ");
                
            }

        }
    }
}