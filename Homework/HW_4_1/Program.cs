// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void ExpNum(int a, int b)
{
    if (a == 0 && b == 0 || a == 0 && b < 0)
    {
        Console.WriteLine($"{a}^{b} -> Решения нет");
    }
    else if (a == 0 && b > 0)
    {
        Console.WriteLine($"{a}^{b} -> 0");
    }
    else if (a != 0 && b == 0)
    {
        Console.WriteLine($"{a}^{b} -> 1");
    }
    else
    {
        int j = Math.Abs(b);
        int result = 1;

        for(int i = 0; i < j; i++)
        {
            result = result * a;
        }
        
        if (b > 0) Console.WriteLine($"{a}^{b} -> {result}");
        else Console.WriteLine($"{a}^{b} -> 1/{result}");
    }
}

Console.Write("A -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("B -> ");
int b = int.Parse(Console.ReadLine());

ExpNum(a, b);
