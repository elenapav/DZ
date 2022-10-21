// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 ->(-0,5; -0,5)

string Cross(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    return $"({x:f1}; {y:f1})";
}

Console.WriteLine("Введите значение b1");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2");
double k2 = int.Parse(Console.ReadLine()!);

if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine("Нет точки пересечения, прямые параллельны");
else
    Console.WriteLine($"Точка пересечения {Cross(b1, k1, b2, k2)}");
