// По заданному номеру дня недели вывести его название.
Console.Write("Введите порядковый номер дня недели: ");
string UserNumber = Console.ReadLine() ?? "";
int number = int.Parse(UserNumber);

if (number == 1)
{
    Console.WriteLine("Понедельник");
}

else if (number == 2)
{
    Console.WriteLine("Вторник");
}

else if (number == 3)
{
    Console.WriteLine("Среда");
}

else if (number == 4)
{
    Console.WriteLine("Четверг");
}

else if (number == 5)
{
    Console.WriteLine("Пятница");
}

else if (number == 6)
{
    Console.WriteLine("Суббота");
}

else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else if (number > 7)
{
    Console.WriteLine("Ошибка ввода данных!");
}

else if (number < 1)
{
    Console.WriteLine("Ошибка ввода данных!");
}