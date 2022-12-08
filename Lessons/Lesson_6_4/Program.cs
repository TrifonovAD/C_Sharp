int[,] FillArray(int rows, int columns, int from, int to)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to);
    }

    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] CopyArray(int[,] arr)
{
    int[,] arrcopy = new int[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arrcopy[i, j] = arr[i, j];
    }
    return arrcopy;
}

Console.WriteLine("Введите количество строк, столбцов массива и интервал чисел:");
int[,] array = FillArray(
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!)
);
Console.WriteLine();

PrintArray(array);
int[,] newarr = CopyArray(array);
Console.WriteLine();
PrintArray(newarr);
