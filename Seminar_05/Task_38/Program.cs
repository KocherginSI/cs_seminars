// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


using System;

namespace Task_38
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите количество элементов массива:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            RandomArrayDifference(userNumber);
        }


        static void RandomArrayDifference(int randomArrayLength)
        {

            int randomArrayIndex = 0;
            double randomDifference = 0;
            
            double[] randomArray = new double[randomArrayLength];
     
            System.Console.WriteLine("Массив случайных вещественных чисел:");

            while (randomArrayIndex < randomArrayLength)
            {
                randomArray[randomArrayIndex] = new Random() .NextDouble();
                System.Console.Write($"{Math.Round(randomArray[randomArrayIndex], 4)} ");
                randomArrayIndex++;

            }  

            Array.Sort(randomArray);

            randomDifference = randomArray[randomArrayIndex - 1] - randomArray[0];
            System.Console.WriteLine("\nРазница между максимальным и минимальным элементом массива:");
            System.Console.WriteLine("{0:f4}", randomDifference);

        

        }

    }

}
