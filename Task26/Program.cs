// Задача 26. Напишите программу, которая
// 1. принимает на вход число и 
// 2. выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// тело программы
int number = Prompt($"Введите число ");
int digit = ChekDigit(number);
Console.WriteLine($"Количество цифр в {number} - {digit}");
// методы
int Prompt(string mess) //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int ChekDigit(int num)
{
    int result = 0;
    if (num == 0) return 1;
    else
    {
        while (num != 0)
        {
            num = num / 10;
            result = result + 1;
        }
    }
    return result;
}