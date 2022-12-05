// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.


void PrintArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

string FindNum(int[] array, int num)

{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return "yes";
    }
    return "no";
}

int[] array = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(array);

int findNumber = int.Parse(Console.ReadLine());
Console.WriteLine(FindNum(array,findNumber));