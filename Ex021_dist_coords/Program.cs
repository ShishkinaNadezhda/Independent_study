// Напишите программу, которая принимает на входдве точки,
// и находит расстояние между ними
// A(3, 6); B(2, 1) = 5.09

int a1, a2, b1, b2;

a1 = Coords("Введите координату x первого числа: ");
a2 = Coords("Введите координату y первого числа: ");
b1 = Coords("Введите координату x второго числа: ");
b2 = Coords("Введите координату y второго числа: ");

double distanse = Distanse(a1, a2, b1, b2);
Console.WriteLine(distanse);

static int Coords(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int a1, int a2, int b1, int b2)
{
    double result = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
    return result;
}
