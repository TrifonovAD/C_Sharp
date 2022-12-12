// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void PrintArray(int[] arr)
{    
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int[] array = FillArray(int.Parse(Console.ReadLine()), 100, 1000);
PrintArray(array);
Console.WriteLine($" -> {EvenCount(array)}");
