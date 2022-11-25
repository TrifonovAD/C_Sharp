// Задача 2: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (b>max) max = b;
if (c>max) max = c;
Console.WriteLine($"max = {max}");