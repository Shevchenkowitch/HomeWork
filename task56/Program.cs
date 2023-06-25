// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}


void SumRow(int[,] array)
{
    int minSum = int.MaxValue; 
    int minSumRow = -1; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0; 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < minSum)
        { 
            minSum = rowSum; 
            minSumRow = i; 
        }
    }

    Console.WriteLine("Номер строки с наименьшей суммой элементов: {0}", minSumRow + 1);
    Console.ReadLine();
}



System.Console.WriteLine();
int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SumRow(array);
