// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int SumNum (int num)
{
    int a = 0;
    if (num == 0) return 0;
    return SumNum (num/10) + num%10;

}

int num = 567;
Console.Write (SumNum (num));