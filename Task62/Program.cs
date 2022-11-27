// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int x = 4;
int[,] Matrix4D = new int[x, x];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix4D.GetLength(0) * Matrix4D.GetLength(1))
{
  Matrix4D[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix4D.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix4D.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix4D.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteMatrix(Matrix4D);

void WriteMatrix (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}