// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());

double[,] array = InputArray(m, n);
PrintArray(array);

double[,] InputArray(int rows, int collumns)
{
    double [,] arr = new double[rows,collumns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            arr[i, j] = Math.Round((new Random().NextDouble() + new Random().Next(-10, 10)),1);
        }
    }
    return arr;
}

void PrintArray(double[,] someArray)
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