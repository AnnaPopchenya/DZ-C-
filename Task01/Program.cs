// 1. Демонстрация решения

// Напишите программу,
// 1. которая на вход принимает два числа и
// 2. проверяет, является ли первое число квадратом второго.

// Например:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет 

Console.WriteLine("Введите  первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 / number2 == number2) 
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
Console.WriteLine("первое число не является квадратом второго");
}