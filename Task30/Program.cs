﻿// Задача 30.Напишите программу, которая
// 1.выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Сколько элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = NewRandomArray(number, 0, 1);   //int[] array = NewArray(number); 
Console.WriteLine($"Полученный массив из {number} элементов");
PrintArray(array);

// Методы
int[] NewRandomArray(int num, int min, int max)  //int[] NewRandomArray(int num)
{
    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(min, max + 1);  // arr[i] = new Random().Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length) Console.Write($", ");
    }
    Console.WriteLine($"]");
}