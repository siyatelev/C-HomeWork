// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите два числа: ");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
if (Number1 == Number2) Console.WriteLine("Числа одинаковые");
else if (Number1 > Number2) Console.WriteLine($"Max = {Number1}, Min = {Number2}");
else Console.WriteLine($"Max = {Number2}, Min = {Number1}");
