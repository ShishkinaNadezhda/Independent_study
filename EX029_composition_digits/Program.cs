// Напишите программу, которая принимает на вход число N
// и выдает произведение всех чисел от 1 до N
// 4 -> 24;
// 5 -> 120;

int num = GetUserFromNumber("Введите целое число A: ", "Ошибка ввода!");
int compozNumbers = GetCompozNumbers(num);
Console.WriteLine($"{num} -> {compozNumbers}");

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

int GetCompozNumbers(int number)
{
    int compoz = 1;
    while (number > 0)
    {
        compoz*=number;
        number--;
    }
    return compoz;
}

