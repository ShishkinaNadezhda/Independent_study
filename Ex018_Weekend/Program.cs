// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
string UsNum = Console.ReadLine() ?? "";
int num = int.Parse(UsNum);

if (num == 1)
{
    Console.WriteLine("Понедельник - рабочий день");
}

if (num == 2)
{
    Console.WriteLine("Вторник - рабочий день");
}
if (num == 3)
{
    Console.WriteLine("Среда - рабочий день");
}
if (num == 4)
{
    Console.WriteLine("Четверг - рабочий день");
}
if (num == 5)
{
    Console.WriteLine("Пятница - рабочий день");
}
if (num == 6)
{
    Console.WriteLine("Суббота - выходной день");
}
if (num == 7)
{
    Console.WriteLine("Воскресенье - выходной день");
}
if (num > 7)
{
    Console.WriteLine("Ошибка ввода!");
}
if (num < 1)
{
    Console.WriteLine("Ошибка ввода!");
}