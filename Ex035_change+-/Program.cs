// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные и наоборот.
// [-4,-8, 8, 2] -> [4, 8, -8, 2]

int[] array = GetArray(4, -9, 9);
PrintArray(array);
Console.Write(" -> ");
ArrayElementSwap(array);

void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
{
    Console.Write(array[index] + " ");
}
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int index = 0; index < size; index++)
    {
        res[index] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

static void ArrayElementSwap(int[] array)
{
       for (int index = 0; index < array.Length; index++)
    {
        array[index] = array[index] * (-1);
    }
}

PrintArray(array);