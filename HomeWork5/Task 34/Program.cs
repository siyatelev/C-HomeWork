// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();
int size = 10;
int max = 1000;
int min = 100;

int[] array = GetArray(size, min, max);
Console.WriteLine($"[{String.Join(",", array)}]");

Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNumber(array)}");

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(min, max);
    return arr;
}

int CountEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) count++;
    return count;
}