// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = GetUserFromNumber("Введите целое число A: ", "Ошибка ввода!");
int B = GetUserFromNumber("Введите целое число B: ", "Ошибка ввода!");
double degree = Math.Pow(A, B);
Console.Write($"{A} в степени {B} -> {degree}");

int GetUserFromNumber(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (IsCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(errormessage);
    }
}