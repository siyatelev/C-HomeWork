// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//1.Вводим длину основного массива. 
//2.Заполняем его случайными числами до 20. 
//3.Разделяем массив на массив нужного нам размера и на массив из остатка основного.

Console.Clear();

Console.WriteLine("Введите длину основного массива:");
int MainArrLength = int.Parse(Console.ReadLine());
int[] array = new int[MainArrLength];

Console.WriteLine("Введите длину второго массива:");
int SecondArrLength = int.Parse(Console.ReadLine());

if (SecondArrLength < 0 || MainArrLength < 0)
{
    Console.WriteLine("Нельзя вводить отрицательные числа!!");
    return;
}
else if (SecondArrLength > MainArrLength)
{
    Console.WriteLine("Длина второго массива должна быть меньше основного массива!!");
    return;
}

FillArray(array);
Decomp(array, SecondArrLength);


void FillArray(int[] ar)  // заполняет основной массив любыми числами 
{
    int Length = ar.Length;
    for (int i = 0; i < Length; i++) ar[i] = new Random().Next(0, 20);
    Console.WriteLine($"Основной массив - [{String.Join(",", ar)}]");
}


void Decomp(int[] ar, int size)    // заполняет основным массивом новые два массива,, длину первого нового вводим сами, длина второго - то, что отстается от основного..
{
    int length = ar.Length;
    int[] ar1 = new int[size];
    int[] ar2 = new int[(length - size)];
    int j = 0;

    for (int i = 0; i < length; i++)
    {
        if (i < size)
        {
            ar1[i] = ar[i];
        }
        else
        {
            ar2[j] = ar[i];
            j++;
        }
    }
    Console.WriteLine($"Первый массив -   [{String.Join(",", ar1)}]");
    Console.WriteLine($"Второй массив -   [{String.Join(",", ar2)}]");
}
