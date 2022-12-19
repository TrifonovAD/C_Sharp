﻿// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintNum(int number)
{
    if (number == 0)
        return;
    PrintNum(number - 1);
    Console.Write($" {number} ");
}
int num = int.Parse(Console.ReadLine());
PrintNum(num);