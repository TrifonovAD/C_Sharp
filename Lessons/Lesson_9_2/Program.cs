void PrintNum(int m, int n)
{
    if (n == m-1)
        return;
    PrintNum(m, n - 1);
    Console.Write($" {n} ");
}
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
PrintNum(m, n);


// Вариант 2

// void Numbers(int m, int n)
// {
    
//     if (m > n) return;
    
//     Console.Write($" {m} ");
//     Numbers(m+1, n);
// }

// Numbers(5,8);