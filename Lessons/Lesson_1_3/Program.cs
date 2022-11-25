// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = -number;
while(count != number)
{
    Console.Write($"{count} ");
    if (number>0) count++;
    else count--;
}
Console.Write($"{count} ");