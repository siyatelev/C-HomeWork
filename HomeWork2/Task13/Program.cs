// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите разрядность максимального числа: "); 
int N = int.Parse(Console.ReadLine());
int a1 = (int)Math.Pow(10, N);
int num = new Random().Next(1, a1); //оочень долго ломался на этом.., пока не понял что из double в int нужно выбираться.
Console.WriteLine(num);

if (num / 100 == 0)
{
    Console.WriteLine($"Наше число {num} и третьей цифры в нем нет");
}
int index = 3;
while (index <= N)
{
    if (num / ((int)Math.Pow(10, index)) == 0)
    {
        int Third = (num / (int)Math.Pow(10, (index-3)))%10;
        Console.WriteLine($"Наше число {num} и третья цифра в нем {Third}");
        break;
    }
    index++;
}
