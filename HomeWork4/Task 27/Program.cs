// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
Sum(Number);

void Sum(int number)
{
    int sumnum = 0;
    while (number > 0)
    {
        sumnum = sumnum + number % 10;
        number = number / 10;
    }
Console.WriteLine($"Сумма цифр в числе = {sumnum}");
}
