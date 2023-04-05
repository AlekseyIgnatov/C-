// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

void SortArray(int[,] array)
{
    int num = 0;
    for (int k = 0; k < array.GetLength(0); k++)
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    num = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = num;
                }
            }

}




Console.Write($"Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int n = rows * columns;
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);

SortArray(array);

Console.WriteLine($"Отсортированный массив выглядит так:");
PrintArray(array);