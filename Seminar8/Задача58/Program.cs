// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] Multi(int[,] inArray, int[,] inArray2)
{
    int[,] matrix = new int[inArray.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inArray2.GetLength(0); k++)
            {
                matrix[i, j] += inArray[i, k] * inArray2[k, j];
            }
        }
    }
    return matrix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк в первой матрице: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первой матрице: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 9);
Console.WriteLine("Матрица 1");
PrintArray(array);


Console.Write("Введите количество строк во второй матрице(равное числу столбцов в первой матрице): ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во второй матрице: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array2 = GetArray(row2, columns2, 0, 9);
Console.WriteLine("Матрица 2");
PrintArray(array2);

Console.WriteLine("Результат перемножения двух матриц");
int[,] array3 = Multi(array, array2);
PrintArray(array3);
