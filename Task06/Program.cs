// Задача 6
// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным 


int i;
Console.Write("Введите число : ");
i = int.Parse(Console.ReadLine());
if (i % 2 == 0)
{
Console.Write("Введенное число является четным");
Console.Read();
 }
else
{
Console.Write("Введенное число нечетное");
Console.Read();
}
