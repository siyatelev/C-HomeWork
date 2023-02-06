// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int B = int.Parse(Console.ReadLine());

Squar(A,B);

void Squar(int num1, int num2)
{
    int result = (int)Math.Pow(num1, num2);
    Console.WriteLine($"число {A} в степени {B} = {result}");
}
