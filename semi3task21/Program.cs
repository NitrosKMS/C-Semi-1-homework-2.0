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
    // AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
    double cat1 = 0;
    double cat2 = 0;
    double cat3 = 0;
    double result = 0.0;

    // cat1 = Math.Abs(xtb) - Math.Abs(xta);
    // cat2 = Math.Abs(ytb) - Math.Abs(yta);
    // cat3 = Math.Abs(ztb) - Math.Abs(zta);
    
    // result = Math.Sqrt((Math.Abs(xta - xtb,2)) + (Math.Abs(yta - ytb,2)) + (Math.Abs(yta - ytb,2)));
    
    cat1 = Math.Pow(xta - xtb,2);
    cat2 = Math.Pow(yta - ytb,2);
    cat3 = Math.Pow(zta - ztb,2);
    result = Math.Sqrt(cat1 + cat2 + cat3);
    
    return Math.Round(result, 2);
}

double resulttwo = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Растояние между точками А и В: {resulttwo}");


