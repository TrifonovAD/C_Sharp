void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collect)
{
    int lengthPA = collect.Length;
    int indexPA = 0;
    while (indexPA < lengthPA)
    {
        Console.WriteLine(collect[indexPA]);
        indexPA++;
    }
}

int IndexOf(int[] collection, int find)
{
    int lengthIO = collection.Length;
    int indexIO = 0;
    int pos = -1;

    while (indexIO < lengthIO)
    {
        if (collection[indexIO] == find)
        {
            pos = indexIO;
            break;
        }
        indexIO++;
    }
    return pos;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int pos = IndexOf(array, 5);
Console.WriteLine("----------------");
Console.WriteLine(pos);
