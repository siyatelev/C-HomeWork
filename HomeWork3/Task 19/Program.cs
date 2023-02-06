// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int Length = N;
int A1 = 0;
int B1 = 0;
int Dif = 0;
int count = 0;
while (Length > 0)
{
    Length = Length / 10;
    count++;
}

for (int i = 1; (i <= count / 2); i++)
{
    A1 = (N / (int)Math.Pow(10, (count - i))) % 10;
    B1 = (N % (int)Math.Pow(10, i)) / ((int)Math.Pow(10, (i - 1)));
    // Console.WriteLine($"Номер цифры = {i}, A1={A1}, B1={B1}");       
    Dif = A1 - B1;

}
if (Dif == 0) Console.WriteLine("число является палиндромом");
else Console.WriteLine("число не является палиндромом");