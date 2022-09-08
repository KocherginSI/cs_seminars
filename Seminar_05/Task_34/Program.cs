// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

namespace Task_34
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите количество элементов массива:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            
            RandomArrayCount(arrayLength);
        }


        static void RandomArrayCount(int arrayLength)
        {
            int[] array = new int[arrayLength];
            int index = 0;
            int countEven = 0;
            while (index < arrayLength)
            {
                array[index] = new Random().Next(100, 1000);
                System.Console.WriteLine($"Новый случайный элемент массива: {array[index]}");

                if (array[index] % 2 == 0)
                {
                    countEven++;
                }
                
                index++;
                
            }

            System.Console.WriteLine($"Количество четных элементов массива: {countEven}");
            
            
        }


    }

}