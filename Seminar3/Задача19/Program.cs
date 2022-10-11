/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Palindrom(int num)
{
        if ((num / 10000) == (num % 10) && ((num / 1000) % 10 == (num % 100) / 10))

        Console.WriteLine("Число - палиндром");

    else
        Console.WriteLine("Число не палиндром");
}
Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine()!);
Palindrom(N);