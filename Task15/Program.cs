// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 8 )
{
    if (a==1) Console.WriteLine("Рабочий");
    else if (a==2) Console.WriteLine("Рабочий");
    else if (a==3) Console.WriteLine("Рабочий");
    else if (a==4) Console.WriteLine("Рабочий");
    else if (a==5) Console.WriteLine("Рабочий");
    else if (a==6) Console.WriteLine("Выходной");
    else Console.WriteLine("Выходной");
}
else Console.Write ("Такого дня недели не существует");