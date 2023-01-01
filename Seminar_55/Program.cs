/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае если это не возможно, программа 
должгна вывести сообщение для пользователя*/

int[,] PrintArray2(int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            int aux = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = aux;         

        }
              
    }
    return arr;
}

void PrintArray(int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
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
int[,] matrix = FillArray(rows, columns, 0, 9);
//ВВодим на экран
PrintArray(matrix);
Console.WriteLine();

if (rows == columns)
{
int[,] array = PrintArray2(matrix);
PrintArray(array);
}
else
{
Console.WriteLine("Замена не возможна");
}