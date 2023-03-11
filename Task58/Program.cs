// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InitMatrix1(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


int[,] InitMatrix2(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] Matrix1, int[,] Matrix2, int[,] Matrix3)
{
    {
        for (int i = 0; i < Matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix3.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < Matrix1.GetLength(1); k++)
                {
                    sum += Matrix1[i, k] * Matrix2[k, j];
                }
                Matrix3[i, j] = sum;
            }
        }
    }
}

Console.WriteLine("Первая матрица: ");
int[,] matrix1 = InitMatrix1(2, 2, 0, 5);
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица");
int[,] matrix2 = InitMatrix2(2, 2, 0, 5);
PrintMatrix(matrix2);
int[,] matrix3 = new int[2, 2];
MultiplyMatrix(matrix1, matrix2, matrix3);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(matrix3);

