// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

int PositiveNums(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum++;
    }

    return sum;
}

Console.WriteLine("Введите числа через запятую и пробел");
string arr = Console.ReadLine()!;
int[] New = NewArray(arr);
Console.WriteLine($"Количество положительных чисел = {PositiveNums(New)}");
