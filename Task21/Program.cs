// Напишите программу, 
// 1.которая принимает на вход координаты двух точек 
// 2.и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек");
Console.Write("numX1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("numY1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("numZ1: ");
int numZ1 = Convert.ToInt32(Console.ReadLine());
Console.Write("numX2: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("numY2: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("numZ2: ");
int numZ2 = Convert.ToInt32(Console.ReadLine());


double result = Distance(numX1, numY1, numZ1, numX2, numY2, numZ2);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double sumSquare = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
    double res = Math.Sqrt(sumSquare);
    return res;
}
