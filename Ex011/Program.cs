// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string UsNum = Console.ReadLine() ?? "";
int N = int.Parse(UsNum);

int i = 1;
int i1 = 0;
int N1 = 0;

if (N % 2 == 0)
{
    N1 = N;
}
else
{
    N1 = N - 1;
}
Console.Write($"{N} -> ");

while (i <= N1)
{
    i1 = i % 2;
    if (i1 == 0)
    {
        Console.Write($"{i}");
        if (i != N1)
        {
            Console.Write(", ");
        }
    }
    i++;
}
