// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1, y1, z1, x2, y2, z2;

x1 = Coords("Введите координату x первой точки: ");
y1 = Coords("Введите координату y первой точки: ");
z1 = Coords("Введите координату z первой точки: ");
x2 = Coords("Введите координату x второй точки: ");
y2 = Coords("Введите координату y второй точки: ");
z2 = Coords("Введите координату z второй точки: ");

double dist = Distanse(x1, y1, z1, x2, y2, z2);
Console.WriteLine(dist);

static int Coords(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}