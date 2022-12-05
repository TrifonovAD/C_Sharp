// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = result + number % 10;
        number = number / 10;
    }

    return Math.Abs(result);
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {SumDigit(num)}");
