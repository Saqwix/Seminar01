// Задача 64:
// 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// 2. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalLow(number, count);


void NaturalLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalLow(n, count + 1);
        Console.Write(count + " ");
    }
}
