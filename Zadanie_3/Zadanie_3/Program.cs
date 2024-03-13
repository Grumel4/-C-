using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Задаем массив
        int[] arr = { 1, 2, 5, 0, 10, 30 };

        // Выводим элементы массива с конца
        PrintArray(arr, arr.Length - 1);
    }

    static void PrintArray(int[] arr, int index)
    {
        // Базовый случай:
        // Если индекс меньше 0, то рекурсия завершается
        if (index < 0)
        {
            return;
        }

        // Рекурсивный случай:
        // Выводим элемент с индексом index и рекурсивно вызываем функцию для индекса index-1
        Console.WriteLine(arr[index]);
        PrintArray(arr, index - 1);
 
    }
}

