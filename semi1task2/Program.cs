//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Эта программа которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первое число и нажмите Enter.");

int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter.");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    Console.WriteLine($"Число {first} большее, а число {second} меньшее.");
}

else
{
    Console.WriteLine($"Число {second} большее, а число {first} меньшее.");
}

