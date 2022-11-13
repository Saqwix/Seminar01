// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


{
int number, s = 0, r;
Console.WriteLine("Введите число : ");
number = int.Parse(Console.ReadLine());
while (number != 0)
{
    r = number % 10;
    number = number / 10;
    s = s + r;
}
Console.WriteLine("Сумма цифр числа равна : "+s);
return;
}