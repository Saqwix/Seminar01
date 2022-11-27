// Задача 60.
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// 2. Напишите программу, которая будет построчно выводить массив, 
// 3. добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int[,,] array3D = new int[arraySizeX, arraySizeY, arraySizeZ];
FillArray(array3D);
PrintIndex(array3D);

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[z, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($"{array3D[i, j, z]}({i},{j},{z}) ");
            }
        }
    }
}