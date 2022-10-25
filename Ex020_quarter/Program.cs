// Напишите программу, которая по введенному номеру четверти будет показывать
// возможный диапазон координат в этой четверти

static void Quarter(int quarter)
{
    if (quarter == 1)
        Console.WriteLine("x > 0, y > 0");

    else if (quarter == 2)
        Console.WriteLine("x < 0, y > 0");

    else if (quarter == 3)
        Console.WriteLine("x < 0, y < 0");

    else if (quarter == 4)
        Console.WriteLine("x > 0, y < 0");

    else
        Console.WriteLine("Некорректный ввод!");
}

int quarter;
Console.WriteLine("Введите номер четверти: ");
quarter = int.Parse(Console.ReadLine() ?? "");

Quarter(quarter);