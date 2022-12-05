// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.


int UmnNums(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }

    return result;
}

Console.WriteLine(UmnNums(int.Parse(Console.ReadLine())));
