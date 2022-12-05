// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


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

int CountNum (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] >=10 && arr [i] <=99) count++;
    }
    return count;
}

int[] array = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(array);

Console.WriteLine(CountNum(array));