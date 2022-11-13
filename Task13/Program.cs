// Задача 13: 
// 1. Напишите программу, которая выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет. 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int count = (int)Math.Log10(num)-2;
if (count < 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
    {
        Console.WriteLine((num % (int)
        Math.Pow(10, count + 1) / (int)Math.Pow(10, count)).ToString());
        Console.ReadLine();
    }