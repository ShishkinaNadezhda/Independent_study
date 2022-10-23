// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
string UsNum1 = Console.ReadLine() ?? "";
int num1 = int.Parse(UsNum1);

Console.Write("Введите второе число ");
string UsNum2 = Console.ReadLine() ?? "";
int num2 = int.Parse(UsNum2);

if (num1 > num2)
{
    Console.WriteLine ($"Первое число {num1} больше второго {num2}");
}
else
{
    Console.WriteLine ($"Второе число {num2} больше первого {num1}");
}

if (num1 == num2)
{
    Console.WriteLine("Ошибка ввода - числа равны! Введите другие числа");
}