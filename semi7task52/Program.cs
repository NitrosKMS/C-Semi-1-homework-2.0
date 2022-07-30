// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine($"Эта программа которая находит среднее арифметическое элементов в каждом столбце.");

Console.WriteLine("Введите количество строк и нажмите Enter.");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок и нажмите Enter.");
int col = Convert.ToInt32(Console.ReadLine());


int [,] matrix;

int[,] FillMatrixRndInt(int row, int col, int min, int max)

{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(min, max + 1);
        }   
    }
    return array;
}

void PrintMatrixInt(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 3}");
            if(j < (array.GetLength(1) -1))
            {   
            Console.Write(", ");}
        }
        Console.WriteLine("  ]");
    }
}

matrix = FillMatrixRndInt(row, col, -9, 9);
PrintMatrixInt(matrix);

int[,] arrayWhole = new int[row, col];
arrayWhole = TransformationArrayWhole(matrix);


Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < col; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < row; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / row, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (int[,] matrix)
{
  int[,] arrayWhole = new int[matrix.GetLength(0), matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(matrix[i, j]);
    }
  }
  return arrayWhole;
}


 
