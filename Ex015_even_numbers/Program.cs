// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму
// Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
string UsNum1 = Console.ReadLine() ?? "";
double num1 = int.Parse(UsNum1);

Console.Write("Введите второе число: ");
string UsNum2 = Console.ReadLine() ?? "";
double num2 = int.Parse(UsNum2);

double res = num1 % num2;
if (res > 0)
{
    Console.WriteLine($"{num1} не кратно {num2}, остаток от деления {res}");
}
else
{
    Console.WriteLine($"{num1} кратно {num2}");
}


