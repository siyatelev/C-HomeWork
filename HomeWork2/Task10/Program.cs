﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 10;
a1 = a1 % 10;
Console.WriteLine($"Наше число {num} и вторая цифра в нем -> {a1}");