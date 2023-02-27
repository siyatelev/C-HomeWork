// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
            sum = sum + arr[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultipliArray(int[,]array1, int[,]array2)
{
    int[,] multiArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0)) 
    {
        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                   multiArray[i,j] += array1[i,k]*array2[k,j];
                } 
            }
        }
    }
    else throw new Exception("Матрицы не согласованы");
    return multiArray;
}

Console.WriteLine("Введите количество строк первого массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого массива:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второго массива:");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго массива:");
int n1 = int.Parse(Console.ReadLine());
int minNum = 0;
int maxNum = 5;
int[,] arrayFirst = FillArray(m, n, minNum, maxNum);
PrintArray(arrayFirst);
int[,] arraySecond = FillArray(m1, n1, minNum, maxNum);
PrintArray(arraySecond);
PrintArray(MultipliArray(arrayFirst, arraySecond));