// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число ");
string UserNumber1 = Console.ReadLine() ?? "";
int Number1 = int.Parse(UserNumber1);

Console.Write("Введите второе число ");
string UserNumber2 = Console.ReadLine() ?? "";
int Number2 = int.Parse(UserNumber2);

if(Number1 > Number2)
{
    Console.Write($"Число {Number1} больше числа {Number2}");
}
else
{
    Console.Write($"Число {Number2} больше числа {Number1}");
}
