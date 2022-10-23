// Напишите программу, которая по заданному номеру выдает название дня недели.

Console.Write("Введите номер: ");
string UsNum = Console.ReadLine() ?? "";
int num = int.Parse(UsNum);

if (num > 7)
{
    Console.WriteLine("Ошибка ввода!");
}

if (num == 0)
{
    Console.WriteLine("Ошибка ввода!");
}

if (num == 1)
{
    Console.WriteLine("Понедельник");
}
if (num == 2)
{
    Console.WriteLine("Вторник");
}
if (num == 3)
{
    Console.WriteLine("Среда");
}
if (num == 4)
{
    Console.WriteLine("Четверг");
}
if (num == 5)
{
    Console.WriteLine("Пятница");
}
if (num == 6)
{
    Console.WriteLine("Суббота");
}
if (num == 7)
{
    Console.WriteLine("Воскресенье");
}
