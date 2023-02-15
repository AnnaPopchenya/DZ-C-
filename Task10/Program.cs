// Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
// int result = ( number /10 ) % 10;
// Console.WriteLine($"Второе число этого числа {result}");

int newNumber = NewNumber (number);
Console.WriteLine($"Второе число этого числа {newNumber}");

int NewNumber (int num)
{
    int result = ( number /10 ) % 10;
    return result;
}