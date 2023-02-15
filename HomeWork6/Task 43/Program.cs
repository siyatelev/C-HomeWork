﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    x = Math.Round(x, 1);
    y = Math.Round(y, 1);
    Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
}
