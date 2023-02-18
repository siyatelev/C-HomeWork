// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> по такому индексу нет элемента.

Console.WriteLine("Введите строку элемента:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец элемента:");
int n = int.Parse(Console.ReadLine());

int[,] array = FillArray(5, 5, -10, 10);
PrintArray(array);
ElementNumber(array, m, n);


int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

void ElementNumber(int[,] newArray, int a, int b)
{
    if (a > 0 &&
        b > 0 &&
        a <= newArray.GetLength(0) &&
        b <= newArray.GetLength(1))
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if (i == a - 1 && j == b - 1) Console.WriteLine($"Значение элемента [{m},{n}]={newArray[i, j]}");
            }
        }
    }
    else Console.WriteLine($"[{m},{n}] - Такого элемента нет в массиве");
}

void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($" {someArray[i, j]}");
        }
        Console.WriteLine();
    }
}
