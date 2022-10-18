//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return res;
}

double[] array = GetArray(5);
Console.WriteLine($"Массив [{String.Join(", ", array)}]");

double min = array[0], max = array [0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
    if (max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");
