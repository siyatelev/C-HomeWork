// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7) Console.WriteLine("Выходной^^");
else if (day >= 1 && day <= 5) Console.WriteLine("Рабочий.._(");
else Console.WriteLine("Нет такого дня!!");

