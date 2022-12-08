// // Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76

double[] FillArray(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }

    return arr;
}

void PrintArray(double[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double MaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }

    Console.WriteLine($"max -> {max}, min -> {min}");
    return Math.Round(max - min, 2);
}

Console.Write("Введите количество элементов массива: ");
double[] array = FillArray(int.Parse(Console.ReadLine()), -99, 100);

PrintArray(array);

Console.WriteLine($"Разница между max и min {MaxMin(array)}");
