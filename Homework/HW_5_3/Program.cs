// // Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76

double[] FillArray(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = GetSecureDoubleWithinRange(1,5);
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

Console.Write("Введите количество элементов массива: ");
double[] array = FillArray(int.Parse(Console.ReadLine()), 1, 10);

PrintArray(array);