// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int sum = firstDigit * 10 + thirdDigit;
// Console.WriteLine(sum);

int newNumber = NewNumber(number);
Console.WriteLine($"Новое число, из первой и последней цифры случайного числа - {newNumber}");

int NewNumber(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int sum = firstDigit * 10 + thirdDigit;

    return sum;
}
