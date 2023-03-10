// Задача 67. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
//  453 -> 12
//  45 ->  9



Console.WriteLine("Введите  число: ");
int number = int.Parse(Console.ReadLine());

int sumDigits = SumDigits (number);
Console.WriteLine($"Сумма цифр числа {number} ->  {sumNumber}");


int SumDigits(int num)
{
    if (num != 0)
    {
        return num % 10 + SumDigits(num / 10);
    }
    else return 0;
}