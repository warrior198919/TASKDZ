// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
//Console.Clear();

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 4, 3, 2, 1 };
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(arr[index]);
        PrintArrayReverse(arr, index - 1);
    }
}
