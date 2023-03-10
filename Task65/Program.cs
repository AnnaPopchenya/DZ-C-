// Задача65. Задайте значение M и N/ Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N/
// M = 1; N = 5 -> 1,2,3,4,5
// M = 4; N = 8 -> 4,5,6,7,8

Console.WriteLine("Введите  число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число N: ");
int number2 = int.Parse(Console.ReadLine());


PrintNumbers(number1, number2);


void PrintNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        PrintNumbers(num1 - 1, num2);

    }
    else if (num2 > num1)
    {
        PrintNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");

    }
    else
    {
        Console.Write($"{num2} ");
    }
}
