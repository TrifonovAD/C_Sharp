// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

int SumOddPosition(int[] arr)
{
    int sumodd = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sumodd += arr[i];
    }
    return sumodd;
}

Console.Write("Введите количество элементов массива: ");
int[] array = FillArray(int.Parse(Console.ReadLine()), -99, 100);

PrintArray(array);
Console.Write($" -> {SumOddPosition(array)}");
