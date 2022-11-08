// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Dist(int x1, int x2, int y1, int y2, int z1, int z2)

{
    double result;
    result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return result;
}

Console.WriteLine("Введите Х координаты точки А");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y координаты точки А");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z координаты точки А");
int az = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Х координаты точки B");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y координаты точки B");
int by = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z координаты точки B");
int bz = int.Parse(Console.ReadLine()!);

Console.Write($"Длина отрезка AB равна : {Dist(ax, bx, ay, by, az, bz):f2}");

