// Задача 68: 
// 1. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// 2. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AckermannFunction(m,n);

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return (Ackermann(m - 1, Ackermann(m, n - 1)));
    }
}

void AckermannFunction(int m, int n)
{
    Console.Write(Ackermann(m, n)); 
}