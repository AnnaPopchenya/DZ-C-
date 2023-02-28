// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min),1, MidpointRounding.ToZero);   
    }
    return arr;
}
// Console.WriteLine(Math.Round(rnd.NextDouble() * (max - min) + min),1, MidpointRounding.ToZero)
// rnd.NextDouble() * (max - min) + min;  
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceElement(double max, double min)
{
    double difference = Math.Round((max - min), 1, MidpointRounding.ToZero);
    return difference;
}

// Console.WriteLine(Math.Round(differenceMaxMinElement, 1, MidpointRounding.ToZero));

double[] array = CreateArrayRndDouble(4, 1, 50);
PrintArrayDouble(array);
double minElement = MinElement(array);
double maxElement = MaxElement(array);
double differenceElement = DifferenceElement(maxElement, minElement);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {maxElement} и минимальным элементов {minElement} равна {differenceElement}");
