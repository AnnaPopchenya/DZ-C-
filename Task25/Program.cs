// Задача 25: Напишите цикл, который 
// 1.принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int step = Step(numberA, numberB);
if (numberB > 0)
{
    Console.WriteLine($"A в степени B равно: {step} ");
}
else Console.WriteLine("Ошибка ввода - число B не натуральное");

int Step(int a, int b)
{
    int stepnumber = a;
    for (int i = 1; i < b; i++)
    {
        stepnumber = stepnumber * a;
    }
    return stepnumber;
}

