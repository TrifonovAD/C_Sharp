// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintNum(int m, int n)
{
    if (n == m-1)
        return;
    PrintNum(m, n - 1);
    Console.Write($" {n} ");
}
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
PrintNum(m, n);


// Вариант 2

// void Numbers(int m, int n)
// {
    
//     if (m > n) return;
    
//     Console.Write($" {m} ");
//     Numbers(m+1, n);
// }

// Numbers(5,8);