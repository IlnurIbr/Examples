/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежать 
в отрезке [10, 99]*/

int CountInterval(int[] array, int begin, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > begin && array[i] < end)
        {
            count++;
        }

    }
    return count;
}

int[] NewArray(int amount, int begin, int end)
{
    int[] array = new int[amount];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end);
    }
    return array; 
}

int[] array = NewArray(123, -500, 500);

Console.WriteLine($"[{string.Join(",", array)}]");

int count = CountInterval(array, 10, 99);

Console.WriteLine($"Количество элементов массива в интервале от 10 до 99: {count} ");