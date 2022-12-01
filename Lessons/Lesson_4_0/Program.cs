// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNums(int num)
{
    int allsum = 0;
    for (int i = 0; i <= num; i++)
    {
        allsum += i;
    }

    return allsum;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
