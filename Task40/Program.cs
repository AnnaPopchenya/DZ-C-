//  Задача 40. Напишите программу, 
// 1. которая принимает на вход три числа и
//  2.принимает, может ли существовать треугольник с сторонами такой длины.
//  каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа");
Console.Write("number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 < 1 || number2 < 1 || number3 < 1) Console.WriteLine("Введено некорректное число");

bool Triangle(int num1, int num2, int num3)
{
    return num1 > num2 + num3 || num2 > num1 + num3 || num3 > num1 + num2;


}

bool result = Triangle(number1,number2,number3);
if (result) Console.WriteLine("Такого треугольника не существует");
else Console.WriteLine("Такой треугольник существует");
