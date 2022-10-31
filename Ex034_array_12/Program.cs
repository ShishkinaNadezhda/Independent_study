// Задайте массив из 12 элементов, заполненный случайными числами
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, 
// отрицательных равна -20.

int[] array = GetArray(12, -9, 9);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int negativeSum = GetNegativeSum(array);

int GetNegativeSum(int[] array)
{
    int negativeSum = 0;
    foreach (int el in array)
    {
        if (el < 0) negativeSum += el;
    }

    return negativeSum;
}

int pozitiveSum = GetPozitiveSum(array);

int GetPozitiveSum(int[] array)
{
    int pozitiveSum = 0;
    foreach (int el in array)
    {
        if (el > 0) pozitiveSum += el;
    }

    return pozitiveSum;
}

Console.Write($"\nСуммф отрицательных чисел массива равна {negativeSum}");
Console.Write($"\nСумма положительных чисел массива равна {pozitiveSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}