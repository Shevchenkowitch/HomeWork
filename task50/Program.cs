// Задача 50. Напишите программу, которая на вход принимает значение
//  элемента в двумерном массиве, и возвращает позицию этого элемента
//  или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchValue(int[,] array)
{
    Console.Write("Введите число для поиска: ");
    int searchValue = int.Parse(Console.ReadLine()!);
    if (searchValue > 0 && searchValue <= array.Length)
    {
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == searchValue)
                {

                    int index = 1;

                    index = i * array.GetLength(1) + j;
                    if (index != -1)
                    {

                        Console.WriteLine($"Элемент найден на позиции {index}");
                    }

                }
            }

        }
    }
     else
    {
        Console.Write($"Элемент не найден");
    }

}



System.Console.WriteLine();
int rows = 3;
int cols = 4;
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SearchValue(array);