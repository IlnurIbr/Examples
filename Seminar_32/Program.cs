/*Задача 32: Напишите программу замена элементов массива: положительные элементы
замените на соответсвующие отрицательные элемент*/

int[] NegaiveNewArray(int[] array)
{
     int[] array2 = new int[array.Length];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = -array[i];
    }
    return array2;
}

int[] NewArray(int amount, int begin, int end)
{
int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = new Random().Next(begin, end);
    }
    return array;
}


int[] array = NewArray(4, -10, 10);
Console.WriteLine($"[{string.Join(",", array)}]");
int[] array2 = NegaiveNewArray(array);
Console.WriteLine($"[{string.Join(",", array2)}]");