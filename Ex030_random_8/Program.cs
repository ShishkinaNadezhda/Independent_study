// Напишите программу, которая выводит массив из 1 и 0 в случайном порядке.
// [0, 1, 1, 0, 1, 0, 0, 0]


int[] array = GetNumber(8);

for (int i = 0; i < 8; i++)
{
    Console.Write($"{array[i] + " "} ");
}


static int[] GetNumber(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);

    }
    return array;
}