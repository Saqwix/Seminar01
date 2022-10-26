// 1. Напишите программу, которая принимает на вход пятизначное число 
// 2. и проверяет, является ли оно палиндромом.
// // Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да


    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int temp = number;
    int number1 = 0;
 if(number >= 10000 && number <= 99999)
 {
    while (temp != 0)
    {
          number1 = number1 * 10 + temp % 10;
          temp /= 10;
    }
 
    if (number == number1)
          Console.WriteLine("${number} - Да");
    else
          Console.WriteLine("${number} - Нет");
    
    
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - Не является пятизначным");
}