// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// pow = Math.Pow(A,B);
Console.WriteLine("Эта программа которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.WriteLine("Введите число А.");

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень В.");

int B = Convert.ToInt32(Console.ReadLine());

int pow(int A, int B)
{
    int res = 1;
    for(int i = 1; i <= B; i++)
{
    res = res * A;
}    
return res;
}

long result = pow(A, B);

Console.WriteLine($"Число {A} в степени {B} -> {result}");