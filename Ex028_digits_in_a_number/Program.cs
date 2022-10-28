// Напишите программу, которая принимает на вход число,
// и выдает количество цифр в этом числе.
// 456 -> 3
// 78 -> 2

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine() ?? "";
int len = number.Length;
Console.Write($"{number} -> {len}");

