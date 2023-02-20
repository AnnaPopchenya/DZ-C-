// Задача 19. Напишите программу, 
// 1.которая принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Ваше число: {num} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");