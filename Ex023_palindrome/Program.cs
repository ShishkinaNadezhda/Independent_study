// Задача 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine() ?? "");

int i1 = N / 10000;
Console.WriteLine($"первая цифра - {i1}, ");

int i2 = N / 1000;
int i2_1 = i2 % 10;
Console.WriteLine($"вторая цифра - {i2_1}, ");

int i3 = N / 100;
int i3_1 = i3 % 10;
Console.WriteLine($"третья цифра - {i3_1}, ");

int i4 = N % 100;
int i4_1 = i4 / 10;
Console.WriteLine($"четвертая цифра - {i4_1}, ");

int i5 = N % 10;
Console.WriteLine($"пятая цифра - {i5}. ");

if (i1 == i5 && i2_1 == i4_1)
    Console.WriteLine("это палиндром");
else
    Console.WriteLine("это не палиндром");


