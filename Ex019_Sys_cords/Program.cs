// Напишите программу, которая принимает на вход координаты точки (x, y)
// и выдает номер четверти плоскости, к которой находится точка.
// координаты не равняются нулю.

Console.Write("Введите X: ");
string UsNumX = Console.ReadLine() ?? "";
int X = int.Parse(UsNumX);

Console.Write("Введите Y: ");
string UsNumY = Console.ReadLine() ?? "";
int Y = int.Parse(UsNumY);

if (X > 0 && Y > 0)
    Console.WriteLine("1");

else if (X > 0 && Y < 0)
    Console.WriteLine("2");

else if (X < 0 && Y < 0)
    Console.WriteLine("3");

else if (X < 0 && Y > 0)
    Console.WriteLine("4");

else
    Console.WriteLine($"Ошибка! Точка попадает на оси координат!");

