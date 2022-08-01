// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1

// 9 5 3 2

// 8 4 4 2

Console.WriteLine($"Эта программа которая упорядочит по убыванию элементы каждой строки двумерного массива.");

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

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}


matrix = FillMatrixRndInt(row, col, -9, 9);
Console.WriteLine("Сгенерированный массив: ");

PrintMatrixInt(matrix);

OrderArrayLines(matrix);

Console.WriteLine("Обработанный массив: ");

PrintMatrixInt(matrix);

