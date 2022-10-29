// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*Console.Write("Введите A: ");
double A = Convert.ToDouble(Console.ReadLine());
double S = 1;

Console.Write("Введите кол-во повторов: ");
double B = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < B; i++)
{
    S *= A;
}

Console.Write($"{A} в степени {B} -> {S}");*/



/*Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
double S = 1;

Console.Write("Введите кол-во повторов: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    S *= x;
}
Console.WriteLine(S);
Console.WriteLine(S);*/


Console.Write("Введите А: ");
double A = Convert.ToDouble(Console.ReadLine());
double S = 1;

Console.Write("Введите B: ");
double B = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < B; i++)
{
    S *= A;
}
Console.Write($"{A} в степени {B} -> {S}");