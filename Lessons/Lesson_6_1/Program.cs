// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.


void Triangle(int a, int b, int c)
{
    if (a < b + c & b < a + c & c < a + b)
        Console.WriteLine("True");
    else
        Console.WriteLine("False");
}

Triangle(
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine())
);
