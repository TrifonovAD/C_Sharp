// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeNumber(int num)
{
    if (num < 1)
    {
        Console.Write("Error");
        return;
    }
    int index = 1;
    while (index < num)
    {
        Console.Write($"{Math.Pow(index, 3)}, ");
        index++;
    }
    Console.Write($"{Math.Pow(index, 3)}");
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
CubeNumber(number);
