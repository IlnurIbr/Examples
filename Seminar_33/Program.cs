/*Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/


int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string MassiveNumber(int[] array, int a)
{
    string answer = "Нет";
    for (int i = 0; i < array.Length; i++)
    
    {
         if (array[i] == a)
         {
            answer = "Да";
         }
    }
    return answer;
    }

int[] array = {6, 7, 19, 435, 3};

int a = EnterData("Введите число: ");

string answer = MassiveNumber(array, a);

Console.WriteLine(answer);
