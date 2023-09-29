// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write(" " + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArraySpiral(int[,] array, int n)
{
    int i = 0;
    int j = 0;
    int count = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = count++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = count++;
        for (k = 0; k < n - 1; k++) array[i, j--] = count++;
        for (k = 0; k < n - 1; k++) array[i--, j] = count++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

int size = 4;
int[,] matrix = new int[size, size];
FillArraySpiral(matrix, size);
PrintMatrix(matrix);