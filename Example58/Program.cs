// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void CompositionAB(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int k = 0; k < arrayB.GetLength(1); k++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                arrayC[i, k] = arrayC[i, k] + arrayA[i, j] * arrayB[j, k];
            }
        }
    }
}



Console.Write($"Введите количество строк массива А: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов массива A: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество строк массива B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов массива B: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
if (columns1 == rows2)
    {
        int[,] arrayA = new int[rows1, columns1];
        int[,] arrayB = new int[rows2, columns2];
        int[,] arrayC = new int[rows1, columns2];
        FillArray(arrayA);
        FillArray(arrayB);
        Console.WriteLine("");
        PrintArray(arrayA);
        Console.WriteLine("");
        PrintArray(arrayB);
        Console.WriteLine("");
        CompositionAB(arrayA, arrayB, arrayC);
        Console.WriteLine("");
        PrintArray(arrayC);
    }
    else Console.Write($"Вы ввели не совместимые матрицы!");