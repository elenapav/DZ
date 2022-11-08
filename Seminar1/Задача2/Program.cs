// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее

Console.WriteLine("введите 1 число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите 2 число");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine($"max={a},min={b}");
}

else if (b > a)
{
    Console.WriteLine($"max={b},min={a}");
}

else 
{
    Console.WriteLine($"Числа равны={a}");
}
