//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Первый способ
for (int i = 2; i <= number; i += 2)
{
    Console.Write($"{i} ");
}

// Второй способ
// for (int i = 1; i <= number; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write($"{i} ");
//     }
// }

// Третий способ (только для положительных чисел)
// foreach(var x in Enumerable.Range(1, number))
// {
//     if(x % 2 == 0)
//     {
//         Console.Write($"{x} ");
//     }
// }