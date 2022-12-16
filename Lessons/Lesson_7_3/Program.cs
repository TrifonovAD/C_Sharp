// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.



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

int SumDiag(int[,] arr)
{
    int sumnum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j) sumnum += arr[i,j];
    }
    return sumnum;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = FillArray(row, column,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));

PrintArray(arr_1);

Console.Write (SumDiag(arr_1));