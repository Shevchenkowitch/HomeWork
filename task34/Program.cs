// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();

    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            count++;
        }

    System.Console.WriteLine($"Количество четных чисел: {count}");
}


int[] array = new int[4];
FillArray(array);


