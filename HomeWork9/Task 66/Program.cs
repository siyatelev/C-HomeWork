// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int a, int b)
{
    int sum = a;
    if (a == b) return a;
    else
    {
        a++;
        sum = a + SumNumber(a, b);
        return sum;
    }
}


Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
if (m > n) { int temp = n; n = m; m = temp; }
Console.WriteLine($"Сумма чисел в промежутке [{m} : {n}] = {SumNumber(m, n)}");
