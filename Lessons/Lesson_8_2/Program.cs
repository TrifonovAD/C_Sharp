// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.


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

// int[,] ChangeRowColumn(int[,] arr)
// {
//     int[,] arr2 = new int[arr.GetLength(1), arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             arr2[j, i] = arr[i, j];    
//     }
//     return arr2;
// }

void ChangeUp(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i,j],arr[j,i]) = (arr[j,i],arr[i,j]);
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Замена невозможна");
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

PrintArray(arr1);
Console.WriteLine();

// int [,] arrTransp = ChangeRowColumn(arr1);
// PrintArray(arrTransp);

ChangeUp (arr1);
PrintArray(arr1);
