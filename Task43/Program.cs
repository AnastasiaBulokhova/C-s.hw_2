/*using System;

public class Answer {
  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      // Введите свое решение ниже
    double[,] matrix = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(minLimitRandom, maxLimitRandom + 1);
        }
    }
    return matrix;

  }

  public static void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

  }

  // Не удаляйте и не меняйте метод Main!
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;

      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}*/






using System;

public class Answer
{
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже


    }

    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {
      // Введите свое решение ниже
int[,] matrix = new int[n, m];
        matrix[0, 0] = 1;
        int counter = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                    continue;
                counter += k;
                matrix[i, j] = counter;
            }
        }
        return matrix;

    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
        Console.WriteLine($"The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
          Console.Write($"{list[i]:N2}");
          Console.Write($"\t");
        }
        Console.Write($" ");

        }
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }