// Напишите программу, которая принимает на вход число N
// и выдает произведение всех чисел от 1 до N
// 4 -> 24;
// 5 -> 120;

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "");
int fact = GetFactorial(N);
Console.Write(fact);

static int GetFactorial(int N)
{
    int a = 1;
    int fact = 1;

    while (a <= N)
    {
       fact = a * fact;
        a++;
    }
    return fact;
}
