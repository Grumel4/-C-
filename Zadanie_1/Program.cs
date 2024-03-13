using System;
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.


class MainClass
{
    public static void Main(string[] args)
    {
        // Задаем значения M и N
        int m = 1;
        int n = 10;

        // Выводим числа от M до N
        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        // Базовый случай:
        // Если M больше N, то рекурсия завершается
        if (m > n)
        {
            return;
        }

        // Рекурсивный случай:
        // Выводим M и рекурсивно вызываем функцию для N-1
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
    }
}

