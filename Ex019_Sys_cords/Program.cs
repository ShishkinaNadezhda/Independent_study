﻿// Напишите программу, которая принимает на вход координаты точки (x, y)
// и выдает номер четверти плоскости, к которой находится точка.
// координаты не равняются нулю.

Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine() ?? "");

if (X > 0 && Y > 0)
    Console.WriteLine("1");

else if (X > 0 && Y < 0)
    Console.WriteLine("2");

else if (X < 0 && Y < 0)
    Console.WriteLine("3");

else if (X < 0 && Y > 0)
    Console.WriteLine("4");

else if (X == 0)
    Console.WriteLine($"{X} неможет равняться нулю!");

else if (Y == 0)
    Console.WriteLine($"{Y} неможет равняться нулю!");
