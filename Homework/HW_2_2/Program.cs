// Задача 2: Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int delSecNum (int number)
{
    int result = (number/100 * 10) + (number%10);
    return result;
}


int num = new Random().Next(100, 1000);
Console.WriteLine(num);
Console.WriteLine(delSecNum(num));