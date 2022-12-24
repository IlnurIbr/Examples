/*Задача 26: Напишите программу, которая принимает на вход число
и выдает количество цифр в числе.*/
int QuantityNumbers(int a)
{
    int s = 0;
    for (int count = 1; a >= 1; count++)
        {
            a = a/10;
            s = count;
        }
        return s;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int a = int.Parse(Console.ReadLine());
    return a;
}


int a = EnterData("Введите число");
int q = QuantityNumbers(a);
Console.WriteLine(q);