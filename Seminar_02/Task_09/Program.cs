using System;

namespace Task_10;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World!");
    }

    static int MaxNumber()
    {
        int number = new Random() .Next(10, 1000);
        int max = 0;
    }
}





// int number = new Random() .Next(10, 99);
// int firstDigit = number % 10;
// int secondDigit = number / 10;

// System.Console.WriteLine(firstDigit);
// System.Console.WriteLine(secondDigit);
// if (firstDigit > secondDigit)
// {
//     System.Console.WriteLine(firstDigit);
// }
// else
// {
//     System.Console.WriteLine($"Max: {secondDigit}");
// }