// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int PlusNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = getRandomArray(8, 100, 1000);
string str = string.Join(", ", array);
System.Console.WriteLine(str);

int result = PlusNum(array);
System.Console.WriteLine($"Количество четных чисел в массиве - {result}");