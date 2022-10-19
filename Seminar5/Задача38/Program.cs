//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
    }
    return res;
}

double MaxMin(double[] array)
{
    double min = array[0], max = array[0];
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
    //return Math.Round((max - min), 2);
    return max - min;
}
double[] array = GetArray(5, 1, 99);
Console.WriteLine($"Массив [{String.Join(";  ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {MaxMin(array):f2}");

