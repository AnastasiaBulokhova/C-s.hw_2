// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int SetNumber(string message)
{
    System.Console.WriteLine($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int N = SetNumber("N");

void Numbers(int n, int count = 1)
{
    if(N == count)
    {
        return;
    }
    else
    {
        Numbers(n, count + 1);
        System.Console.Write(count + " ");
    }
}

Numbers(N);