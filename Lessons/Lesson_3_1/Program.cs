// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quarters(string quart)
{
    if (quart == "I")
        Console.WriteLine("x > 0 or y > 0");
    else if (quart =="II")
        Console.WriteLine("x < 0 or y > 0");
    else if (quart == "III")
        Console.WriteLine("x < 0 or y < 0");
    else if (quart == "IV")
        Console.WriteLine("x > 0 or y < 0");
    else 
        Console.WriteLine("error");
}

Quarters(Console.ReadLine());