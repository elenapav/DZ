// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    if ((m > 0) && (n == 0))
        return AkkermanFunction(m - 1, 1);
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.WriteLine($"Введите 1 число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите 2 число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана A({m},{n}) = {AkkermanFunction(m, n)}");
