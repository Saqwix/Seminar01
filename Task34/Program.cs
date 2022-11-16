// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

FillArrayRandomarrbers(arr);
Console.WriteLine("array:");

PrintArray(arr);
int count = 0;
for (int m = 0; m < arr.Length; m++)
if (arr[m] % 2 == 0)
count++;
Console.WriteLine($" {arr.Length} чисел в масиве | {count} четных ");


void FillArrayRandomarrbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,999);
    }
}
void PrintArray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i!=arr.Length -1)Console.Write($" {arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}