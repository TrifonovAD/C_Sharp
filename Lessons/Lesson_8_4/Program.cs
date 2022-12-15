// 4. Задайте двумерный массив из целых чисел. Напишите программу,
//    которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

(int, int) MinIndex(int[,] arr)
{
    (int, int) minIndex = (0, 0);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] < arr[minIndex.Item1, minIndex.Item2])
                minIndex = (i, j);
    }
    return minIndex;
}

int[,] ArrayWithoutMin(int[,] arr, int minrow, int mincol)
{
    int[,] newArr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int m = 0,
        n;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        n=0;
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i != minrow | j != mincol) 
            {
                newArr[m,n] = arr[i,j];
                if (j != mincol) n++;        
            }
        if (i != minrow) m++;        
    }
    return newArr;
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

(int, int) minIndex = MinIndex(arr1);
Console.WriteLine(minIndex);
int[,] arr2 = ArrayWithoutMin(arr1, minIndex.Item1, minIndex.Item2);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);