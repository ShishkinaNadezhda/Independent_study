// Напишите программу, которая принимает число
// и выводит его квадрат.

Console.Write("Введите число: ");
string UsInp = Console.ReadLine() ?? "";
int Num = int.Parse(UsInp);

Console.WriteLine($"{UsInp} -> {Num * Num}");
