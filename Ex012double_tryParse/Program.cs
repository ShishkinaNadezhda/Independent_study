internal class Program
{
    private static void Main(string[] args)
    {
        // Новые формулировки кода
        static void Main(string[] args)
        {
            double varA;
            while (true)
            {
                Console.Write("Введите число: ");
                if (double.TryParse(Console.ReadLine(), out varA))
                    break;
                Console.WriteLine($"Ошибка ввода!");
            }
        }
    }
}