// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


using System;

namespace Task_37
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите количество элементов массива:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            RandomArrayProduct(userNumber);
        }


        static void RandomArrayProduct(int randomArrayLength)
        {
            int randomArrayIndex = 0;
            int productArrayIndex = 0;
            int productArrayLength = 0;
            
            long[] randomArray = new long[randomArrayLength];
     
            System.Console.WriteLine("Массив случайных чисел:");

            while (randomArrayIndex < randomArrayLength)
            {
                randomArray[randomArrayIndex] = new Random().Next(-99, 99);
                System.Console.Write($"{randomArray[randomArrayIndex]} ");
                randomArrayIndex++;
                
            }  
            
            randomArrayIndex--;


            System.Console.WriteLine();
            System.Console.WriteLine($"Массив произведений:");


            if (randomArrayLength % 2 == 0)
            {
                productArrayLength = randomArrayLength / 2;
                long[] productArray = new long[productArrayLength];

                while (productArrayIndex < productArrayLength)
                {

                productArray[productArrayIndex] = randomArray[productArrayIndex] * randomArray[randomArrayIndex];
                System.Console.Write($"{productArray[productArrayIndex]} ");
                productArrayIndex++;
                randomArrayIndex--;

                }
                
            }

            else
            {
                productArrayLength = randomArrayLength / 2 + 1;
                long[] productArray = new long[productArrayLength];

                while (productArrayIndex < productArrayLength - 1)
                {

                productArray[productArrayIndex] = randomArray[productArrayIndex] * randomArray[randomArrayIndex];
                System.Console.Write($"{productArray[productArrayIndex]} ");
                productArrayIndex++;
                randomArrayIndex--;

                }

                productArray[productArrayIndex] = randomArray[productArrayIndex + 1];
                System.Console.Write($"{randomArray[randomArrayIndex]} ");
          

            }


        }
    }

}