// Напишите программу, которая принимает два числа
// и проверяет, является ли первое квадратом второго

Console.Write("Введите первое число: ");
string UsNum1 = Console.ReadLine() ?? "";
int num1 = int.Parse(UsNum1);

Console.Write("Введите второе число: ");
string UsNum2 = Console.ReadLine() ?? "";
int num2 = int.Parse(UsNum2);
int square = num2*num2;

if (square == num1)
{
    Console.WriteLine($"{UsNum1} является квадратом {UsNum2}");
}
else
{
    Console.WriteLine($"{UsNum1} не является квадратом {UsNum2}");
}