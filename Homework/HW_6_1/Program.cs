// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


// Вариант 1:

int InpNum()
{
    string tmp_num;
    string s_num = "";
    int num;
    int pos = 0;
    Console.Write("Введите число: ");
    tmp_num = Console.ReadLine();
    while (int.TryParse(tmp_num, out num))
    {
        s_num += $"{tmp_num} ";
        if (num > 0)
            pos++;
        Console.Write("Введите число: ");
        tmp_num = Console.ReadLine();
    }
    Console.Write(s_num);
    return pos;
}
Console.WriteLine($"-> {InpNum()} числа больше 0");

// Вариант 2:

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             Console.Write(", ");
//     }
// }

// int[] InpNumArray()
// {
//     string tmp_num;
//     string s_num = "";
//     int num;
//     Console.Write("Введите число: ");
//     tmp_num = Console.ReadLine()!;
//     while (int.TryParse(tmp_num, out num))
//     {
//         s_num += $"{tmp_num} ";
//         Console.Write("Введите число: ");
//         tmp_num = Console.ReadLine()!;
//     }
//     s_num = s_num[..^1];
//     int[] arr = Array.ConvertAll(s_num.Split(), int.Parse);
//     return arr;
// }
// int[] array = InpNumArray();

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }

// PrintArray(array);
// Console.WriteLine($" -> Кол-во элементов больше 0: {count}");
