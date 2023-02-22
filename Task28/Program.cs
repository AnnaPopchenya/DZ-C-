// Задача 28. Напишите программу, которая
// 1. принимат на вход число N и
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int factorial = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
}
else Console.WriteLine("Ошибка ввода - число не натуральное");


int Factorial(int num) // num = number
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            factorial = factorial * i;
        }
    }
    return factorial;
}
