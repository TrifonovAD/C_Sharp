// Задача 3: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// void ThirdNum (int number)
// {
//     if (number<100 & number>-100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         number = number/100%10;
//         if (number<0) number = -number;
//         Console.WriteLine(number);
//     }
// }

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// ThirdNum(num);


// 3. Напишите программу, которая выводит третью цифру
//    заданного числа или сообщает, что третьей цифры нет.

// ----------------------------------- 1 вариант


void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("there is no third digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()));


// ----------------------------------- 2 вариант


void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    int tr_num = -1;
    string txt;
    
    while (num > 99)
    {
        tr_num = num % 10;        
        num = num / 10; 
    }
    txt = $"{tr_num}";
    if (tr_num == -1)
    {
        txt = "there is no third digit";        
    }
    Console.WriteLine(txt);    
}

ThirdNum(641);
ThirdNum(32879);
ThirdNum(32079);
ThirdNum(78);