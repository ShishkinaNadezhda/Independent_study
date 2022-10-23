// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"{num} -> ");

int num1 = num / 100;
Console.WriteLine($"Первая цифра числа: {num1}");

int num2 = num / 10;
int num2_2 = num2 % 10;
Console.WriteLine($"Вторая цифра числа: {num2_2}");

int num3 = num % 10;
Console.WriteLine($"Третья цифра числа: {num3}");

int numres = num1 * 10 + num3;
Console.WriteLine($"{num} -> {numres}");

