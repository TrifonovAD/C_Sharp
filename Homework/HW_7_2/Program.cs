// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

void PrintArrayNumber(int[,] arr, int rowPosition, int columnPosition)
{
    if (
        rowPosition > arr.GetLength(0)
        | rowPosition <= 0
        | columnPosition > arr.GetLength(1)
        | columnPosition <= 0
    )
        Console.Write($"Array element [{rowPosition}, {columnPosition}] does not exist.");
    else
        Console.Write(
            $"Array element {rowPosition}, {columnPosition} -> {arr[rowPosition - 1, columnPosition - 1]}"
        );
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr1 = FillArray(
    row,
    column,
    int.Parse(Console.ReadLine()!),
    int.Parse(Console.ReadLine()!)
);

PrintArray(arr1);
Console.WriteLine();

Console.Write("Enter the row position: ");
int rowPosition = int.Parse(Console.ReadLine()!);
Console.Write("Enter the column position: ");
int columnPosition = int.Parse(Console.ReadLine()!);

PrintArrayNumber(arr1, rowPosition, columnPosition);
