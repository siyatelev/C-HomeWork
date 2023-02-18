// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int collumns = int.Parse(Console.ReadLine());

int[,] array = InputArray(rows, collumns);
PrintArray(array);
double[] averageArray = AverageValueCollumn(array);
Console.WriteLine($"[{String.Join("; ", averageArray)}]");



int[,] InputArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
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

double[] AverageValueCollumn(int[,] someArray)
{
    double[] arr = new double[someArray.GetLength(1)];
    for (int j = 0; j < someArray.GetLength(1); j++)
    {
        double averageCollumn = 0;
        for (int i = 0; i < someArray.GetLength(0); i++)
        {
            averageCollumn += someArray[i, j];
        }
        arr[j] = Math.Round(averageCollumn / someArray.GetLength(0), 1);
    }
    return arr;
}