// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray(int m, int n, int minValue,int maxValue)
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
        int sum=0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
            sum=sum+arr[i, j];
        }
        Console.WriteLine($"    Сумма: {sum}");
    }
}
int MinSumRow(int[,] arr,int maxValue)
{
    int minRow = 0;
    int minSumRow=maxValue*arr.GetLength(1);
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            minRow = i;
        }
    }
    return minRow;
}

Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());
int minNum = 0;
int maxNum = 10;
int[,] array = FillArray(m, n, minNum,maxNum);
PrintArray(array);
Console.WriteLine($"Строка с минимальной суммой: {MinSumRow(array,maxNum) + 1}");
