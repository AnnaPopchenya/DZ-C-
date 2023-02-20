// Задача 20.Напишите программу, которая
// 1.принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 2D пространстве
// А (3,6); В(2, 1)-> 5,09
// A(7, -5); В(1, -1)-> 7,21

Console.WriteLine("Введите координаты двух точек");
Console.Write("numX1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("numY1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("numX2: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("numY2: ");
int numY2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(numX1, numY1, numX2, numY2);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));


double Distance(int x1, int y1, int x2, int y2)
{
    double sumSquare = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
    double res = Math.Sqrt(sumSquare);
    return res;
}


// Matw.Sqrt(5);
// Math.Poe (2,10);
// double d = 5,09998774;
// double dRound = Math.Round (d,2, MidpointRounding.ToZero);
//Console.WriteLine (dRound);