// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите  число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число N: ");
int number2 = int.Parse(Console.ReadLine());


// PrintNumbers(number1, number2);


// void PrintNumbers(int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         Console.Write($"{num1} ");
//         PrintNumbers(num1 - 1, num2);

//     }
//     else if (num2 > num1)
//     {
//         PrintNumbers(num1, num2 - 1);
//         Console.Write($"{num2} ");

//     }
//     else
//     {
//         Console.Write($"{num2} ");
//     }
// }

int sum = SumNumbers(number1, number2);
Console.WriteLine($"Сумма чисел от {number1} до {number2} = {sum}");

int SumNumbers(int num1, int num2) // num = number
{
    if (num1 < num2)
    {
        return SumNumbers(num1 + 1, num2) + num1;
    }
    else return num1;
    
}

// if (num1 == num2)
//         return num1;
//     return SumNumbers(num1 + 1, num2) + num1;