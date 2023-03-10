// Задача 69. напишите программу, которая на вход принимает два числа А  и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

// int Factorial(int n)
// {
//     if (n==1) return 1;
//     else return n* FactorialRec(n-1);
// }
// Console.WriteLine(FactorialRec(10));


int Exponentiation(int num, int deg)
{
    if (deg == 0) return 1;
    else return num * Exponentiation(num, deg - 1);
}

Console.WriteLine("Введите  число A: ");
int footing = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число B: ");
int degree = int.Parse(Console.ReadLine());
int result = Exponentiation(footing, degree);
if (degree < 0) Console.WriteLine("Ошибка ввода");
else Console.WriteLine(result);

