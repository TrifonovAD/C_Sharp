int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
        result = arg2;
    if (arg3 > result)
        result = arg3;
    return result;
}

int a1 = 25;
int b1 = 12;
int c1 = 8;
int a2 = 35;
int b2 = 17;
int c2 = 153;
int a3 = 67;
int b3 = 47;
int c3 = 13;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
