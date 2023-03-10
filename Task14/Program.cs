// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (MultiplicityTwoNumbers(number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");


bool MultiplicityTwoNumbers(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

// 2 метод решения
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = 7;
// int num2 = 23;

// if (Multiplicity(num, num1, num2))
// Console.WriteLine ($"Введите число {num} кратно {num1} и {num2}");
// else Console.WriteLine ($"Введите число {num}  не кратно {num1} и {num2}");

// bool Multiplicity( int number, int number1, int number2)
// {
//     return number % number1 == 0 && number % number2 == 0;
// }
