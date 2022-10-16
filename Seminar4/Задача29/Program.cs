//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] NewArray(string stringArray)
{
    string[] nums = stringArray.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        array[i] = int.Parse(nums[i]);
    }
    return array;
}

void PrintArray(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
}

Console.WriteLine("Введите числа через запятую и пробел");
string arr = Console.ReadLine()!;
int[] New = NewArray(arr);
PrintArray(New);
