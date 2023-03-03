﻿// Задача 48. Задайте двумерный массив размера m и n,
// каждый элемент в массиве находится по формуле: Amn = m+n



int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];    //0,  1
    for (int i = 0; i < matrix.GetLength(0); i++)  //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //columns
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4);
PrintMatrix(array2d);