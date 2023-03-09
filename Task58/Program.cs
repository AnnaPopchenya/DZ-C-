// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];    //0,  1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //columns
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

void MultipluMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    int[,] matrix3 = new int[i, k];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += Martrix1[i, k] * matrix2[k, j];
            }
            matrix3[i, j] = sum;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[,] array2d2 = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d2);
MultiplyMatrix(Matrix1, Matrix2, Matrix3);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(Matrix3);