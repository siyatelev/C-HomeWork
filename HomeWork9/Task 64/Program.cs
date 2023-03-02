// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void NaturalNumber(int n, int a)
{
    if (a > n) return;
    else 
    {
        NaturalNumber(n,a+1);
        Console.Write($"{a}, ");
    }
}


Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
int x=1;
NaturalNumber(n,x);
