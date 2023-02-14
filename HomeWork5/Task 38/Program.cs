// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Clear();
int size = InputNumber("Введите размер массива:");
double[] array = FillArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");

double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}

Console.WriteLine($"разница между максимальным и минимальным элементов массива: {max - min}");



int InputNumber(string message)
{
    Console.Write($"{message} ");
    int res = int.Parse(Console.ReadLine());
    return res;
}


double[] FillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++) arr[i] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    return arr;
}


