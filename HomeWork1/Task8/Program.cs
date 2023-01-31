// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число:");
int index = int.Parse(Console.ReadLine());
int count = 2;
if (index<2) Console.WriteLine("нет четных чисел в интересующем нас интревале");
while (count<=index)
{
    if (count%2 == 0) Console.Write($"{count} ");
    count++;
}
 
