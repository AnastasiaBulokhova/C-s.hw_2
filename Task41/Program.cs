// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
//пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message) //метод считывает число с консоли
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int res = Convert.ToInt32(value);
    return res;
}

int[] getArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} число");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int PosNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int size = Prompt($"Введите колличество чисел: ");
int[] array;
array = getArray(size);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше нуля - {PosNum(array)}");