//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

var rand = new Random();
double[] getRandomArray(int length, int min, int max)
{
    double[] array = new double[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble()+rand.Next(0,100), 2); // два знака после запятой
    }
    return array;
}

double MaxNum(double[] array)
{
    double result = 0;
    for (int i = 0; i < array.Length; i++)   // min max = array[1],
    {
        if (array[i] > result)
        {
            result = array[i];
        }
    }
    return result;
}

double MinNum(double[] array)
{
    double res = MaxNum(array);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < res)
        {
            res = array[i];
        }
    }
    return res;
}

double NumDiff(double[] array)
{
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        diff = MaxNum(array) - MinNum(array);
    }
    return diff;
}


double[] array = getRandomArray(6, 1, 99);
System.Console.WriteLine(string.Join("; ", array));

double max = MaxNum(array);
System.Console.WriteLine($"Максимальное значение = {max}");

double min = MinNum(array);
System.Console.WriteLine($"Минимальное значение = {min}");

double diff = NumDiff(array);
System.Console.WriteLine($"Разница между максимальным и минимальным значениями -> {diff, 2}");