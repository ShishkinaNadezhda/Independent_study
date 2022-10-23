// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму
// Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

//Console.Write("Введите первое число: ");
/*string UsNum1 = Console.ReadLine() ?? "";
double num1 = int.Parse(UsNum1);

Console.Write("Введите второе число: ");
string UsNum2 = Console.ReadLine() ?? "";
double num2 = int.Parse(UsNum2);*/

int Enternumber()
{
    int number;
    while(true)
    {
        Console.WriteLine("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int num1 = Enternumber();
int num2 = Enternumber();

Console.Write($"{num1}, {num2} -> ");
if(num1 % num2 ==0)
    Console.WriteLine($"{num1} кратно {num2}");
else
    Console.WriteLine($"{num1} не кратно {num2}, остаток {num1 % num2}");
