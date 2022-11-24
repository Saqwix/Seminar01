// Задача 50. 
// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите строку элемента: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows < m && columns < n) Console.WriteLine("Элемент массива с такими координатами существует: " + matrix[rows, columns]);
else Console.WriteLine("Элемент массива с такими координатами не существует");
