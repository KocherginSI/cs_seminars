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