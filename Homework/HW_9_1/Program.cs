// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNum(int number)
{
    if (number == 0)
        return;
    Console.Write($" {number} ");
    PrintNum(number - 1);    
}
int num = int.Parse(Console.ReadLine());
PrintNum(num);