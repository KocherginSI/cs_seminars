// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

namespace Task_36
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите количество элементов массива:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            
            RandomArraySumm(arrayLength);
        }


        static void RandomArraySumm(int arrayLength)
        {
            int[] array = new int[arrayLength];
            int index = 0;
            int summOdd = 0;
            while (index < arrayLength)
            {
                array[index] = new Random().Next(-99, 99);
                System.Console.WriteLine($"Новый случайный элемент массива: {array[index]}");

                if (array[index] % 2 != 0)
                {
                    summOdd += array[index];
                }
                
                index++;
                
            }

            System.Console.WriteLine($"Сумма нечетных элементов массива: {summOdd}");
            
            
        }


    }

}