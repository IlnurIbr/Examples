/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных эементов
массива*/

int SumNegativeNumbers(int [] array)
{
    int sum = 0;
    for (int i = 0; i < 12; i++)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


int SumPositiveNumbers(int [] array)
{
    int sum = 0;
    for (int i = 0; i < 12; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}




int[] NewArray()
{
int[] array = new int[12];
for (int i = 0; i<12; i++)
{
    array[i] = new Random().Next(-9, 9);
}
return array;
}


int [] array = NewArray();
int a = SumNegativeNumbers(array);
int b = SumPositiveNumbers(array);
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Сумма отрицательных элементов = {a}");
Console.WriteLine($"Сумма положительных элементов = {b}");