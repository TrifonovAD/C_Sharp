// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ArithmeticMean(int[,] arr)
{
    double arithMean;
    for (int i =0; i < arr.GetLength(1); i++)
    {
        arithMean = 0;
        for (int j=0; j < arr.GetLength(0); j++) arithMean+=arr[j,i];
        Console.WriteLine ($"Arithmetic Mean column {i+1} -> {Math.Round(arithMean/arr.GetLength(0), 2)}");
    }
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
Console.WriteLine();
PrintArray(arr1);
Console.WriteLine();
ArithmeticMean(arr1);