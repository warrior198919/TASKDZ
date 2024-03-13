// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Console.Clear();
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два неотрицательных числа m и n:");
        Console.Write("m = ");
        int m;
        if (!int.TryParse(Console.ReadLine(), out m) || m < 0)
        {
            Console.WriteLine("Ошибка: введите неотрицательное число для m.");
            return;
        }
        
        Console.Write("n = ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Ошибка: введите неотрицательное число для n.");
            return;
        }

        int result = Ackermann(m, n);
        Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
