// Задача 1: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a>b) Console.WriteLine($"max = {a}, min = {b}");
else if (a<b) Console.WriteLine($"max = {b}, min = {a}");
else Console.WriteLine($"{a} = {b}");