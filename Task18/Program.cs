﻿// Задача 18: Напишите программу, 
// 1. которая по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string quarter = Console.ReadLine();

string result = QuartedFind(quarter);          
Console.WriteLine ($"Yt {result}");

string QuartedFind (string q)
{
     if (q == "1") return "x > 0, y > 0";
     if (q == "2") return "x < 0, y > 0";
     if (q == "3") return "x < 0, y < 0";
     if (q == "4") return "x > 0, y < 0";
     return "0";
}


/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */

//методы
string Prompt(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}
string Range(string num)
{
    if (num == "1") return "x>0, y>0";
    if (num == "2") return "x<0, y>0";
    if (num == "3") return "x<0, y<0";
    if (num == "4") return "x>0, y<0";
    return "0";
}

//тело программы
string number = Prompt("Введите номер четверти ");
string range = Range(number);
string result = range=="0" ? 
                "Не коректный ввод данных" 
                : $" диапазон возможных координат точек в этой четверти {range}"; 
Console.WriteLine(result);