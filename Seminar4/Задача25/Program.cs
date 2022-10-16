// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
void Degree(int a, int b)
{
    int result = 1;
    {
        for (int i = 1; i <= b; i++)
            result = result * a;
    }
    Console.WriteLine($"{a} в степени {b} = {result}");
}

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine()!);
Degree(A, B);

