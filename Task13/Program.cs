// Напишите программу, которая 
// 1.выводит третью цифру заданного числа 
// 2.или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 3)
{
    while (number > 999)
    {
        int number1 = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра {result}");  
}
   else   Console.WriteLine("Третьей цифры нет");

