// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] array = Input(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Количество положительных чисел: {PositiveNum(array)}");

int[] Input(int length)
{
    Console.WriteLine("Заполните массив");
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int PositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}