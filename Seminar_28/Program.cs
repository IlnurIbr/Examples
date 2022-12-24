/*Задача 28: Напишите программу, которая принимает на вход число N
 и выдает произведение чисел от 1 до N*/
Console.Clear();

int EnterData(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int ProductOfNumbers(int n)
{
int product = 1;

    for (int count = 1; count <= n; count++)
    {
        product = product*count;
    }
    return product;
}

 int n = EnterData("Введите число: ");
 int c = ProductOfNumbers(n);
 Console.WriteLine($"Произведение чисел от 1 до {n} = {c}");