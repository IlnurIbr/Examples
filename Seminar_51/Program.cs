/*Задача 51: Задайте двумерный массив и вывести сумму элементов главной диагонали*/



int Sum(int[,] arr)
{
    int Sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                Sum = Sum + arr[i,j];
            }

        }
        }
    return Sum;
    
}

void PrintArray(int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");;
        }
        Console.WriteLine();
    }
    
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end+1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}



//Запрос количества строк
int rows = EnterData("Введите количество строк: ");
//Запрос количества столбцов
int columns = EnterData("Введите количество столбцов: ");
//Создаем двумерный массив и заполняем его случайными числами
int[,] matrix = FillArray(rows, columns, 0, 10);
//ВВодим на экран
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(Sum(matrix));



