// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int usernumber = GetUserFromNumber("Введите целое число: ", "Ошибка ввода!");
int number = usernumber;

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

if (number < 99)
{
    int n1 = number / 10;
    int n2 = number % 10;
    Console.Write($"{usernumber} -> {n1 + n2}");
}

if (number < 999 && number > 99)
{
    int n1 = number / 100;
    int n2 = number % 100;
    int n2_1 = n2 / 10;
    int n3 = n2 % 10;
    Console.Write($"{usernumber} -> {n1 + n2_1 + n3}");
}

if (number < 9999 && number > 999)
{
    int n1 = number / 1000;
    int n2 = number / 100;
    int n2_1 = n2 % 10;
    int n3 = number / 10;
    int n3_1 = n3 % 10;
    int n4 = number % 10;
    Console.Write($"{usernumber} -> {n1 + n2_1 + n3_1 + n4}");
}
