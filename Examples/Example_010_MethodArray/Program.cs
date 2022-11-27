int[] array = { 14, 22, 39, 24, 15, 67, 7, 88 };
int index = 0;
int n = array.Length;
int find = 88;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
