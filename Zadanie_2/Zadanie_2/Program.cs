using System;
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


class MainClass
{
    public static void Main(string[] args)
    {
        // Задаем значения m и n
        int m = 3;
        int n = 2;

        // Вычисляем значение функции Аккермана
        int result = Ackerman(m, n);

        // Выводим результат
        Console.WriteLine(result);
    }

    static int Ackerman(int m, int n)
    {
        // Базовый случай:
        // A(0, n) = n + 1
        if (m == 0)
        {
            return n + 1;
        }

        // Рекурсивный случай:
        // A(m, 0) = A(m-1, 1)
        // A(m, n) = A(m-1, A(m, n-1))
        if (n == 0)
        {
            return Ackerman(m - 1, 1);
        }

        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

