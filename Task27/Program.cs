// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    System.Console.WriteLine($"Введите число {message} : ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int num = GetNumber("");
int sum = 0;
while (num != 0)
    {
        sum+=num%10;
        num/=10;
    }
System.Console.WriteLine(sum);