/*Задача 24: Написать программу, которая принимает число А и выдает сумму от 1 до А
7 - 28
4 - 10
8 - 36*/

int SumOfNumbers(int a)
{
    int sum = 0;

    for (int count = 0; count <= a; count++)
    {
        sum = sum + count;
    }        
    return sum;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int a = int.Parse(Console.ReadLine());
    return(a);    
}

int a = EnterData("Введите число");
int s = SumOfNumbers(a);
Console.WriteLine($"Сумма чисел = от 1 до {a} = {s}");
