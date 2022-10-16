// Напишите программу, которая
// 1. на вход принимает число и
// 2. выдает его квадрат (число умноденное на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine(square);
// Console.WriteLine($"Квадрат числа {num} - {square}");


// if (num > 5 && num < 10)
// {

// }


// Задача_1
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");