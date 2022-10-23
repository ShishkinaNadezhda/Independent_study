// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string UsNum = Console.ReadLine() ?? "";
int num = int.Parse(UsNum);

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
if (num > 99 && num < 1000)
{
    Console.WriteLine($"Третья цифра -> {num % 10}");
}
if (num > 999 && num < 10000)
{
    Console.WriteLine($"Третья цифра -> {num % 100 / 10}");
}
if (num > 9999 && num < 100000)
{
    Console.WriteLine($"Третья цифра -> {num % 1000 / 100}");
}
if (num > 99999 && num < 1000000)
{
    Console.WriteLine($"Третья цифра -> {num % 10000 / 1000}");
}