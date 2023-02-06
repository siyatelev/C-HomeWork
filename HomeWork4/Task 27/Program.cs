// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
Sum(Number);

void Sum(int num)
{
    int Sum = 0;
    while (num > 0)
    {
        Sum = Sum + num % 10;
        num = num / 10;
    }
Console.WriteLine($"Сумма цифр в числе = {Sum}");
}
