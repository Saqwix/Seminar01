// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив: ");
void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;         // массив вещественных чисел
        }
}

PrintArray(num);
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine(" ]");                 //вывод масива
    Console.WriteLine();
}

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int a = 0; a < num.Length; a++)
{
    if (num[a] > max)
    {
        max = num[a];
    }
    if (num[a] < min)
    {
        min = num[a];
    }
}
Console.WriteLine($"Минимальное значение:{min}");
Console.WriteLine($"Максимальное значение:{max}");
Console.WriteLine($"Разница между самым большим и самым маленьким значением:{max - min}");
Console.ReadLine();



// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         double num = rnd.NextDouble() * (max - min) + min;    
//         array[i] = Math.Round(num, 1);
//     }
//     return array;                          // массив вещественных чисел(семинар)
// }
