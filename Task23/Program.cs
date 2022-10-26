// 1. Напишите программу, которая принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int n)
{
    if (n > 0)
    {
        int index = 1;
        while (index <= n)
        {
            Console.WriteLine($"{index} {index*index*index}");
            index++;
        }
    }
    else Console.WriteLine("некоректные данные");
}

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);