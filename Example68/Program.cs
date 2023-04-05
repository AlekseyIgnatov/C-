// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
    {
        if(m == 0) return n+1;
            {
                if (m > 0 && n == 0) 
                    {
                    return Akkerman(m - 1, 1);
                    }
                else return Akkerman(m - 1, Akkerman(m , n - 1));
            }
    }



Console.Write("Введите значение m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {m}, n = {n} -> A({m},{n}) = {Akkerman(m,n)}");

