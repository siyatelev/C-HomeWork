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
// int[] averageArray = AverageValueCollumn(array);
// Console.WriteLine($"[{String.Join(", ", averageArray)}]");






int[,] InputArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
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
                Console.Write($" {someArray[i,j]}");
            }
            Console.WriteLine();
        }
}

// int AverageValueCollumn(int[,] arr)
// {
//     int [] averageArray = new int[arr.GetLength(0)];
//     int averageCollumn = 0;
//     for (int j = 0; j < arr.GetLength(1); i++)
//     {
//         for (int i = 0; i < arr.GetLength(0); j++)
//         {
//             averageCollumn+=arr[i,j];
//         }
//         averageArray[j]=averageCollumn/arr.GetLength(1);
//     }
// return averageArray;
// }