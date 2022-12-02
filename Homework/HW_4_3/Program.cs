// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray (int[] array, int j, int a, int b)
{
    for (int i = 0; i < j; i++)
    {
        array[i] = new Random().Next(a,b);
    }

    // return array;
}

void PrintArray (int[] array, int j)
{
    for (int i = 0; i < j-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[j-1]}");
}


Console.Write("Введите количество элементов в массиве: ");
int lengthArray = int.Parse(Console.ReadLine());

Console.Write("Диапазон чисел: от ");
int startRandom = int.Parse(Console.ReadLine());
Console.Write("Диапазон чисел: до ");
int endRandom = int.Parse(Console.ReadLine());

int[] array = new int[lengthArray];

FillArray (array, lengthArray, startRandom, endRandom);
PrintArray (array,lengthArray);
