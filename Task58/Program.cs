﻿// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];

FillMatrixRandom(matrix);
PrintMatrix2D(matrix);
Console.WriteLine();
FillMatrixRandom(secondMatrix);
PrintMatrix2D(secondMatrix);
Console.WriteLine();

if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintMatrix2D(resultMatrix);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}