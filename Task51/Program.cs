// Задача 51. задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1,1)) и т.д.



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

int MainDiagonalSumElems(int[,] matrix)
{
    int sum = 0;
    // int size = matrix.GetLength(0);
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1);
    
    for (int i = 0; i < matrix.GetLength(0) && i< matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
int mainDiagonalSumElems = MainDiagonalSumElems(array2d);
Console.WriteLine($"Сумма элементов главной диагонали = {mainDiagonalSumElems}");