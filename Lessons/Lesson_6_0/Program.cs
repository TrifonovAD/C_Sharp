// 1. Напишите программу, которая перевернёт одномерный массив
//    (последний элемент будет на первом месте, а первый - на последнем и т.д.)


int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void ReverseMass (int [] arr1)
{
    int size = arr1.Length;
    for (int i = 0; i < size / 2; i++)
        (arr1[i], arr1[size-i-1]) = (arr1[size-i-1], arr1[i]);
}

Console.WriteLine("Введите количество элементов массива и интервал чисел:");
int[] array = FillArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

PrintArray(array);
ReverseMass(array);
PrintArray(array);