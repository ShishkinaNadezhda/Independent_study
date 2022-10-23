// Напишите программу, которая принимает на вход трехзначное число,
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
string UsNum = Console.ReadLine() ?? "";
int num = int.Parse(UsNum);

int num1 = 0;
int num1_1 = 0;

num1 = num / 10;
num1_1 = num1 % 10;

if (num > 100 && num < 999)
    Console.WriteLine($"Вторая цифра числа: {num1_1}");
else
    Console.WriteLine("Ошибка ввода!");


