// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Clear();
int size = InputNumber("Введите размер массива:");
double[] array = FillArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"разница между максимальным и минимальным элементов массива: {Dif(array)}");

double Dif(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var el in array)
    {
        if (el < min) min = el;
        if (el > max) max = el;
    }
return max-min;
}

int InputNumber(string message)
{
    Console.Write($"{message} ");
    int res = int.Parse(Console.ReadLine());
    return res;
}


double[] FillArray(int size)
{
    double[] arr = new double[size];
    // for (int i = 0; i < size; i++) arr[i] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    for (int i = 0; i < size; i++) arr[i] = new Random().NextDouble() + new Random().Next(-20, 20);
    return arr;
}


