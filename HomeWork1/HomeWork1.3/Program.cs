﻿// Задача 6: Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
if (Number % 2 == 0) Console.WriteLine($"Число чётное - {Number}");
else Console.WriteLine($"Число НЕчётное - {Number}");
