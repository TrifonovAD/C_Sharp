// 4. Напишите программу вычисления модуля числа.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int mod = num;
if (num < 0)
    mod = -num;
Console.Write($"Модуль числа {num} равен {mod}");
