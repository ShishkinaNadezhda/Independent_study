// Напишите программу, которая принимает на вход число A
// и выдает сумму чисел от 1 до A
// 4 -> (1+2+3+4) -> 10

Console.Clear();
int num = GetUserFromNumber("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

// выводит в консоль сообщение message
// преобразовывает введенную пользователем строку в тип int
// в случае ошибки выводит в консоль сообщение errormessage

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

int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum+=number;
        number--;
    }
    return sum;
}