// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
string UsNum1 = Console.ReadLine() ?? "";
int num1 = int.Parse(UsNum1);

Console.Write("Введите второе число: ");
string UsNum2 = Console.ReadLine() ?? "";
int num2 = int.Parse(UsNum2);

Console.Write("Введите третье число: ");
string UsNum3 = Console.ReadLine() ?? "";
int num3 = int.Parse(UsNum3);
int max = 0;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"Максимальное число -> {max}");
