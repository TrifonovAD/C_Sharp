// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string DayNum (int num)
{
    string s_day;
    if (num<6 & num>0) 
    {
        s_day = "нет";
    }
    else if (num == 6 | num == 7)
    {
        s_day = "да";
    }
    else
    {
        s_day = "ошибка";
    }
    return s_day;
}

Console.Write ("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine(DayNum(day));
