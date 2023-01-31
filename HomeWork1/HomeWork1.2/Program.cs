// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите три числа: ");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
int Number3 = int.Parse(Console.ReadLine());
int max = Number1;
if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;
Console.WriteLine($"Наибольшее число - {max}");