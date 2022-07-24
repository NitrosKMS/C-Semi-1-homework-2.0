// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine($"Эта программа которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;.");

double[,] cof = new double[2, 2];
double[] Point = new double[2];

double[] Decision(double[,] coeff)

{
  Point[0] = (cof[1,1] - cof[0,1]) / (cof[0,0] - cof[1,0]);
  Point[1] = Point[0] * cof[0,0] + cof[0,1];
  return Point;
}

void InputCof()

{
  for (int i = 0; i < cof.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < cof.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      cof[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

InputCof();
Decision(cof);
Console.Write($"Точка пересечения прямых: ({Point[0]}, {Point[1]})");