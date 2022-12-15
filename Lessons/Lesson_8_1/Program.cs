// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.


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

void ChangeRowArray(int [,] arr)
{
    int i = arr.GetLength(0)-1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        (arr [0,j], arr [i,j]) = (arr [i,j], arr [0,j]);
    }
    
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = FillArray(row, column,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));

PrintArray(arr_1);
ChangeRowArray(arr_1);
Console.WriteLine();
PrintArray(arr_1);