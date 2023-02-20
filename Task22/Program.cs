// Задача 22.Напишите программу, которая
// 1.принимает на вход число (N) и
// 2.выдаёт таблицу квадратов чисел от 1 до N 
// 5 -> 1,4,9,16,25.
// 2 -> 1, 4

// 1 Метод
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Square(number);

// void Square(int num)
// {
//     int index = 1;
//     while (index <= num)
//     {
//         Console.WriteLine($"{index, 5} - {index * index, 5}");
//         index++;
//     }
// } // Prompt

// 2 Метод
int number = Prompt("Введите натуральное число: ");

if (number > 0) PrintSqr(number);   // проверка числа на натуральность
else Console.WriteLine("Введено не натуральное число. Начните заново.");

void PrintSqr(int n)             //невозвратный метод, вывод результата в консоль
{
    Console.WriteLine("Число    Квадрат числа");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i,5} {i * i,5}");
    }
}

int Prompt(string message)         //метод ввода
{
    Console.WriteLine(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}



