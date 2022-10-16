// Задача08
// 1. Напишите программу, которая на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N.

        Console.Write("Напишите первое число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Напишите последнее число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();