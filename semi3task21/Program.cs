// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Эта программа которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите координаты точки А.");

Console.Write ("Х: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write ("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write ("Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B.");

Console.Write ("Х: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write ("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write ("Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance (int xta, int yta, int zta,  int xtb, int ytb, int ztb)
{
    int cat1 = 0;
    int cat2 = 0;
    int cat3 = 0;
    double result = 0.0;

    cat1 = Math.Abs(xta) - Math.Abs(xtb);
    cat2 = Math.Abs(yta) - Math.Abs(ytb);
    cat3 = Math.Abs(zta) - Math.Abs(ztb);
    result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return Math.Round(result, 3);
}

double result = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Растояние между точками А и В: {result}");


