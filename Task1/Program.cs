// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

// Console.WriteLine("Введите значение натурального числа M:");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение натурального числа N:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write($"M = {m}; N = {n} -> \"");
// RangeNaturalNumbers(m, n);
// Console.WriteLine("\"");

// void RangeNaturalNumbers(int M, int N)
// {
//     if (M == N)
//     {
//         if (N >= 0) Console.Write($"{N}");
//     }
//     else
//     {
//         if (M < N)
//         {
//             RangeNaturalNumbers(M, N - 1);
//             if (N >= 0) Console.Write($", {N}");
//         }
//         else if (M > N)
//         {
//             if (N >= 0) Console.Write($"{M}, ");
//             RangeNaturalNumbers(M - 1, N);
//         }
//     }
// }

// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m;
//         if (!int.TryParse(Console.ReadLine(), out m))
//         {
//             Console.WriteLine("Ошибка: введите целое число для m.");
//             return;
//         }

//         Console.Write("Введите значение n: ");
//         int n;
//         if (!int.TryParse(Console.ReadLine(), out n))
//         {
//             Console.WriteLine("Ошибка: введите целое число для n.");
//             return;
//         }

//         int result = Ackermann(m, n);
//         Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
//     }
// }
// using System;

// class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение натурального числа M:");
        int m;
        if (!int.TryParse(Console.ReadLine(), out m) || m < 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число для M.");
            return;
        }

        Console.WriteLine("Введите значение натурального числа N:");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число для N.");
            return;
        }

        Console.Write($"M = {m}; N = {n} -> \"");
        RangeNaturalNumbers(m, n);
        Console.WriteLine("\"");
    }

    static void RangeNaturalNumbers(int M, int N)
    {
        if (M == N)
        {
            if (N >= 0) Console.Write($"{N}");
        }
        else
        {
            if (M < N)
            {
                RangeNaturalNumbers(M, N - 1);
                if (N >= 0) Console.Write($", {N}");
            }
            else if (M > N)
            {
                if (N >= 0) Console.Write($"{M}, ");
                RangeNaturalNumbers(M - 1, N);
            }
        }
    }
}
