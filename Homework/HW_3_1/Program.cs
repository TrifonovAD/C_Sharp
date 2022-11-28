// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void RevertNumber(int number)
{
    int newnum = 0;
    int count = number;
    while (count > 0)
    {
        newnum = newnum * 10 + count % 10;
        count = count / 10;
    }
    if (newnum == number)
        Console.WriteLine($"Число {number} - палиндром");
    else
        Console.WriteLine($"Число {number} - не палиндром");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
RevertNumber(num);

// RevertNumber(12321);
// RevertNumber(121);
// RevertNumber(1234321);
