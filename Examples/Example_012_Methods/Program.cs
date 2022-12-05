// // Вид 1


// void Method1()
// {
//     Console.WriteLine("Author Alexey Trifonov");
// }

// // Method1();




// // Вид 2


// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine($"{msg} {i + 1}");
//         i++;
//     }
// }

// // Method2(msg: "Message");
// // Method21(msg:"Text", count: 4);
// // Method21(count: 6, msg:"Text");


// // Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// // int year = Method3();
// // Console.WriteLine (year);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }

//     return result;
// }

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }

//     return result;
// }

// string res = Method4(count: 10, text: "z ");
// Console.WriteLine(res);



// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($@"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// =======Работа с текстом======
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// Ясна ли задача?

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;

//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//               + "ежели бы вас послали вместо нашего милого "
//               + "Винценгероде, вы бы взяли приступом согласие "
//               + "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


// Сортировка массива от минимального к максимальному


// int[] array = { 1, 6, 2, 8, 4, 6, 4, 5, 3, 1 };

// void PrintArray (int[] arr)
// {
//     int count = arr.Length;
//     for (int i = 0; i<count; i++)
//     {
//         Console.Write ($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void SortArray (int [] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray (array);
// SortArray (array);
// PrintArray (array);

// Сортировка массива от максимального к минимальному

int[] array = { 1, 6, 2, 8, 4, 6, 4, 5, 3, 1 };

void PrintArray (int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i<count; i++)
    {
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SortArray (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray (array);
SortArray (array);
PrintArray (array);