//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.


string NumbRec(int n)
    {
        if(n == 0) return "";
        return n +" "+ NumbRec(n-1);
    }



Console.Write("Введите значение N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(NumbRec(n));
