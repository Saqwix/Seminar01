// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a==1) Console.WriteLine("Рабочий");
if (a==2) Console.WriteLine("Рабочий");
if (a==3) Console.WriteLine("Рабочий");
if (a==4) Console.WriteLine("Рабочий");
if (a==5) Console.WriteLine("Рабочий");
if (a==6) Console.WriteLine("Выходной");
if (a==7) Console.WriteLine("Выходной");
if (a > 7 || a < 1 ) Console.Write ("Такого дня недели не существует");