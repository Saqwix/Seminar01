// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArrayRandomarrbers(arr);
Console.WriteLine("Масив: ");
PrintArray(arr);
int sum = 0;

for( int d = 0; d < arr.Length; d+=2)
sum = sum + arr[d];
Console.WriteLine($"в масиве всего {arr.Length} чисел |  Cумма нечетных чисел, {sum}");

void FillArrayRandomarrbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,10);
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
    Console.WriteLine(" ]");
}