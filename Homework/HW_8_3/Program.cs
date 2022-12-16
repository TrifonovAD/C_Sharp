// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{arr[i, j], 6} ");
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] arrResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
                arrResult[i, j] += (matrix1[i, k] * matrix2[k, j]);
        }
    }
    return arrResult;
}

Console.WriteLine("Enter matrix 1.");
Console.Write("Enter the number of rows: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column1 = int.Parse(Console.ReadLine()!);

int[,] arr1 = FillArray(
    row1,
    column1,
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!)
);

Console.WriteLine("Enter matrix 2.");
Console.Write("Enter the number of rows: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column2 = int.Parse(Console.ReadLine()!);
int[,] arr2 = FillArray(
    row2,
    column2,
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!)
);

if (column1 != row2)
    Console.WriteLine("Multiplication is impossible");
else
    {
        Console.Clear();
        int [,] arrResult = MultiplicationMatrix(arr1, arr2);
        Console.WriteLine("Matrix A");
        PrintArray(arr1);
        Console.WriteLine("Matrix B");
        PrintArray(arr2);
        Console.WriteLine("Matrix A * Matrix B");
        PrintArray(arrResult);
    }


