/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.*/
Console.Clear();

int[] array = NewArray();
Console.Write($"[{string.Join(",", array)}]");

int[] NewArray()
{
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{ 
array[i] = new Random().Next(2);
}
return array;
}
