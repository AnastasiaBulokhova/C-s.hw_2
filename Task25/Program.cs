//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message)
{
    System.Console.WriteLine($"Введите число {message} : ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numX = GetNumber("X");
int numY = GetNumber("Y");

System.Console.WriteLine($"X = {numX}, Y = {numY}");

double result = 0;
double MathPow(string num)
{

    for (int i = 0; i <= numY; i++)
    {
        i = numY;
        double result = Math.Pow(numX, numY);
        System.Console.WriteLine(result);
    }
    return result;
}

double pow = MathPow("result");