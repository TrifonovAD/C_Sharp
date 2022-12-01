int NumLength (int number)
{
    int length = 0;
    if (number == 0) return 1;
    n = Math.Abs(n);
    while (number > 0)
    {
        number = number / 10;
        length++;
    }
    return length;

}

Console.WriteLine (NumLength(int.Parse(Console.ReadLine())));