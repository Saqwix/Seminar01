// Задача 25: 
// 1. Напишите цикл, который принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Число A");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Число B");
// double b = Convert.ToDouble(Console.ReadLine());
// double c = Math.Pow(a,b);  //- метод
// Console.WriteLine($"Результат:{c} ");
// Console.ReadLine();

Console.WriteLine("Число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B");
int B = Convert.ToInt32(Console.ReadLine());
ToDegree(A,B);
void ToDegree(int a, int b)
{
    int c = 1;
    for (int i = 1; i<= B; i++)
    {
        c = c*A;
    }
    Console.WriteLine($"Результат:{c} ");
    return;
}
