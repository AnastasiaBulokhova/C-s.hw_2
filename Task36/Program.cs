// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int SumMinus(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = getRandomArray(5, -100, 100);
string str = string.Join(", ", array);
System.Console.WriteLine(str);

int result = SumMinus(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");