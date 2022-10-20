// Напишите программу, которая принимает число
// и выводит его квадрат

Console.Write("Введите число: ");
string UserNumber = Console.ReadLine() ?? "";
int Number = int.Parse(UserNumber);

int result = Number * Number;
Console.WriteLine($"Квадрат числа {Number} -> {result}");