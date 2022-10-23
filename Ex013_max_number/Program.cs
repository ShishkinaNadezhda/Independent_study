// Напишите программу, которая выдает число из отрезка [10, 100]
// и находит наибольшую цифру числа.

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {num}");

int num1 = num / 10;
int num2 = num % 10;

if (num1 > num2)
{
    Console.WriteLine($"Первая цифра {num1} - максимальная");
}
else
{
    Console.WriteLine($"Вторая цифра {num2} - максимальная");
}
