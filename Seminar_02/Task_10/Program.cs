// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

bool askUser = true;
int secondDigit = 0;

while (askUser == true)
{
    System.Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0)
    {
        if (number / 100 < 1 | number / 1000 >= 1)
        {
            System.Console.WriteLine("Вы ввели недопустимое число.");
        }
        else
        {
            secondDigit = number / 10 % 10;
            System.Console.WriteLine($"Вторая цифра числа '{number}' -> {secondDigit}");
            break;
        }
    }
    

    if (number < 0)
    {
        if (number / -100 < 1 | number / -1000 >= 1)
        {
            System.Console.WriteLine("Вы ввели недопустимое число.");
        }
        else
        {
            secondDigit = number / 10 % 10;
            System.Console.WriteLine($"Вторая цифра числа '{number}' -> {secondDigit}");
            break;
        }
    }
}


