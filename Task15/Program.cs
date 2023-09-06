/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 8 && num > 0)
{
    if (num > 5)
    {
        System.Console.WriteLine("Сегодня выходной 0_0");
    }
    else
    {
        System.Console.WriteLine("Сегодня рабочий день ~_~");
    }
}
else
{
    System.Console.WriteLine("Такого дня недели нет X~X");
}