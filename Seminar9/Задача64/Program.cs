// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetPrint(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return start + " " + GetPrint(start - 1, end);
}

Console.WriteLine($"Введите число: ");
int m = 1;
int n = int.Parse(Console.ReadLine()!); ;
Console.WriteLine(GetPrint(n, m));
