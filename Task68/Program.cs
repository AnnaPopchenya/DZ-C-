// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите  число m: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число n: ");
int number2 = int.Parse(Console.ReadLine());

int functionAckermana = FunctionAckermana(number1, number2);
Console.WriteLine($"A({number1},{number2}) = {functionAckermana}");

int FunctionAckermana(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunctionAckermana(m - 1, 1);
    }
    else
    {
        return FunctionAckermana(m - 1, FunctionAckermana(m, n - 1));
    }
}


