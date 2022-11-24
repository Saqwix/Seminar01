﻿// Задача 47. 
// 1. Задайте двумерный массив размером m×n, 
// 2. заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Кол-во строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кол-во столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void FillArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write("| ");
        for (int j = 0; j < n; j++)
        { 
            Console.Write(matrix[i, j] + "  |"); 
        }
        Console.WriteLine("");
    }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
