﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Summ(int m, int n)
    {
        if(m == n) return m;
        return m + Summ(m+1, n);
    }



Console.Write("Введите значение M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Summ(m,n));

