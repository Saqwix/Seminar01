// Задача_04
// Напишите программу, которая принимает на
// 1. вход три числа 
// 2. и выдаёт максимальное из этих чисел.



{ double a, b, c, max;
Console.Write("a b c: ");
var s = Console.ReadLine().Split(" ");
a = Convert.ToDouble(s[0]);
b = Convert.ToDouble(s[1]);
c = Convert.ToDouble(s[2]);
max = Math.Max(a, Math.Max(b, c));
Console.WriteLine(max); }