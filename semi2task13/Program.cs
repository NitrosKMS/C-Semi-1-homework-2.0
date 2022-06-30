// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Эта программа которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число.");

int number = Convert.ToInt32(Console.ReadLine());

int Third(int num)
{
    while (num >= 1000)
    {
    num = num / 10;
    }
    num = num % 10;
    return num;
}


if (number < 100) Console.Write($"У числа {number} третьей цифры нет");
else Console.Write($"У числа {number} третьей цифрой является {Third(number)}");



