// Напишите программу, которая выводит возведение числа 
// в заданную степень.

Console.Write("Введите число: ");
string UserNumber = Console.ReadLine() ?? "";
int Number = int.Parse(UserNumber);

Console.Write("Введите степень: ");
string Degree = Console.ReadLine()?? "";
int degree = int.Parse(Degree);

double result = Math.Pow(Number, degree);

Console.WriteLine($"Число {Number} в степени {Degree} -> {result}");
