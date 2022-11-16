// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElements(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    return a + SumElements(a + 1, b);
}

Console.WriteLine($"Введите 1 число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите 2 число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов = {SumElements(m, n)}");
