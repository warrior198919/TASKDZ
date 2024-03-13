// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();


{
    static void Main(string[] args)
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
