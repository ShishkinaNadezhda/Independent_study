// Напишите программу, которая принимает на вход число,
// и выдает количество цифр в этом числе.
// 456 -> 3
// 78 -> 2

Console.Write ("Введите число: ");
int A = int.Parse(Console.ReadLine() ?? "");
Console.Write($"{A} -> ");
int a = 0;

while (A > 0)
    {
        A /= 10;
        a ++;
    }
    
  Console.Write($"{a}");