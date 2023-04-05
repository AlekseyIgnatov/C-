// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void SearchMinString(int[,] array)
{
    int min = 0;
    int sum = 0;
    int minIndex = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                        if (i==0) 
                            {
                                min = sum;
                                minIndex = i;
                            }
                    }    
                if (sum < min) 
                    {
                        min = sum;
                        minIndex = i;
                    }
            }
    Console.WriteLine($"У строки номер {minIndex+1} наименьшая сумма чисел.");        
}




Console.Write($"Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
SearchMinString(array);