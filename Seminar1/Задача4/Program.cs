// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел

Console.WriteLine("введите 1 число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 2 число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 3 число");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"max={max}");

