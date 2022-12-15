// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillArray(int rows, int columns, int from, int to)
{
    double[,] arr = new double[rows, columns];
    Random newNum = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            arr[i, j] = Math.Round(newNum.NextDouble() * (to - from) + from, 2);
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 6} ");
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

double[,] arr_1 = FillArray(
    row,
    column,
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!)
);

PrintArray(arr_1);
