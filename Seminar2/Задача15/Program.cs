﻿//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру от 1 до 7");
int num = int.Parse(Console.ReadLine()!);

if (num < 1 || num > 7)
{
    Console.WriteLine("Это не цифра от 1 до 7");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это не выходной");
}