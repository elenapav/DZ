// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralArray()
{
    int n = 4;
    int[,] array = new int[n, n];
    int i = 0;
    int j = 0;

    for (int k = 1; k <= n * n; k++)
    {
        array[i, j] = k;
        if (i <= j + 1 && i + j < n - 1) j++;
        else if (i < j && i + j >= n - 1) i++;
        else if (i >= j && i + j > n - 1) j--;
        else i--;
    }
    PrintArray(array);
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
Console.WriteLine("Матрица, заполненная спирально");
SpiralArray();
