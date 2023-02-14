// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();
int size = 9;
int max = 10;
int min = -10;

int[] array = GetArray(size, min, max);
Console.WriteLine($"[{String.Join(",", array)}]");

Console.WriteLine($"Сумма элементов на нечетных позициях: {SumOddPositions(array)}");

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(min, max);
    return arr;
}

int SumOddPositions(int[] arr)
{
    int SumOdd = 0;
    for (int i = 1; i < arr.Length; i=i+2) SumOdd=SumOdd+arr[i];
    return SumOdd;
}