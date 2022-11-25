// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

int num = int.Parse(Console.ReadLine());
if (num%2 == 0) 
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

