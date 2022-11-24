// Задача 52. 
// 1. Задайте двумерный массив из целых чисел. 
// 2. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];
FillMatrixRndNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avg = (avg + numbers[i, j]);
    }
    avg = avg / rows;
    Console.Write(avg + "; ");
}
Console.WriteLine();

PrintMatrix(numbers);

void FillMatrixRndNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}