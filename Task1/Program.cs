// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

Console.WriteLine("Введите значение натурального числа M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение натурального числа N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> \"");
RangeNaturalNumbers(m, n);
Console.WriteLine("\"");

void RangeNaturalNumbers(int M, int N)
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
