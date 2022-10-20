// По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Введите первое число: ");
string UserNumber1 = Console.ReadLine() ?? "";
int number1 = int.Parse(UserNumber1);

Console.Write("Введите второе число: ");
string UserNumber2 = Console.ReadLine() ?? "";
int number2 = int.Parse(UserNumber2);
int degree = 2;

double result = Math.Pow(number1, degree);

if (result == number2)
{
    Console.WriteLine($"Первое число {UserNumber1} является квадратом второго {UserNumber2}");
}
else
{
    Console.WriteLine($"Первое число {UserNumber1} не является квадратом второго {UserNumber2}");
}
