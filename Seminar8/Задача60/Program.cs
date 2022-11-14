// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void GetArray(int[,,] array)
{
    int[] mass = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(10, 100);
        int num = mass[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (mass[i] == mass[j])
                {
                    mass[i] = new Random().Next(10, 100);
                    j = 0;
                    num = mass[i];
                }
                num = mass[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = mass[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($" [{i},{j},{k}] = {inArray[i, j, k]}; ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество элементов в 3ьей размерности: ");
int diag = int.Parse(Console.ReadLine()!);

int[,,] array = new int[row, columns, diag];
Console.WriteLine("Трехмерная матрица");
GetArray(array);
PrintArray(array);
