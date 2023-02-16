// Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели, 
// 2.и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());


// if (day >= 1 && day <=7) {
// 	if (day >= 6) 
//     {
// 		Console.WriteLine("Выходной");
// 	} else {
// 		Console.WriteLine("Не выходной");
// 	}
// } 
// else 
// {
// 	Console.WriteLine("Введите число от 1 до 7");
// }

if (MultiplicityTwoNumbers(day)) Console.WriteLine("Выходной");
else Console.WriteLine("Не выходной");

bool MultiplicityTwoNumbers(int num)
{
    if (num >= 1 && num <= 7) ;
    return num >= 6;
}
