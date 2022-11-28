// Задача 3: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void ThirdNum (int number)
{
    if (number<100 & number>-100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        number = number/100%10;
        if (number<0) number = -number;
        Console.WriteLine(number);
    }
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
ThirdNum(num);