// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
string UsNum = Console.ReadLine() ?? "";
int num = int.Parse(UsNum);
int res = 0;

res = num % 2;
if (res == 0)
{
    Console.WriteLine($"Число {UsNum} является четным");
}
else
{
    Console.WriteLine($"Число {UsNum} не является четным");
}