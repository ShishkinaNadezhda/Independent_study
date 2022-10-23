// Выяснить является ли число чётным.
Console.Write("Введите число: ");
string UsNum = Console.ReadLine() ?? "";
double num = int.Parse(UsNum);
double res = 0;

res = num % 2;

if (res == 0)
{
    Console.WriteLine($"Число {UsNum} является четным");
}

else
{
    Console.WriteLine($"Число {UsNum} не является четным");
}