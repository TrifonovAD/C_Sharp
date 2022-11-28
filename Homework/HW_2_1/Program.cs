// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

void SecondNum(int number)
{
    Console.WriteLine(number);
    Console.WriteLine(number/10%10);
}

SecondNum (456);
SecondNum (782);
SecondNum (918);

//Вариант 2. С вводом числа и проверкой на диапазон от 100 до 999

int num = 0;

while (num<100 | num>1000)
{
    Console.Write("Введите трехзначное число: ");
    num = int.Parse(Console.ReadLine());
}

SecondNum (num);