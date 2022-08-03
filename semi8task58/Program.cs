// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine($"Эта программа которая находит произведение двух матриц");

Console.WriteLine("Введите количество строк 1й матрицы и нажмите Enter.");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок 1й матрицы и нажмите Enter.");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrixone = new int[row, col];

CreateMatrixint(matrixone);

PrintMatrixInt(matrixone);

Console.WriteLine("Введите количество строк 2й матрицы и нажмите Enter.");
int rowtwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок 2й матрицы и нажмите Enter.");
int coltwo = Convert.ToInt32(Console.ReadLine());

int[,] matrixtwo = new int[rowtwo, coltwo];

CreateMatrixint(matrixtwo);

PrintMatrixInt(matrixtwo);

int[,] resultMatrix = new int[row, coltwo];

WorkMatrix(matrixone, matrixtwo, resultMatrix);

void CreateMatrixint(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-9,9);
    }
  }
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


void WorkMatrix(int[,] matrixone, int[,] matrixtwo, int[,] resultMatrix)
{ 
   for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                    for (int k = 0; k < matrixone.GetLength(1); k++)
                        {
                            sum += matrixone[i,k] * matrixtwo[k,j];
                        }
                    resultMatrix[i,j] = sum;
            }
        }
}
Console.WriteLine($"произведение матриц - ");

PrintMatrixInt(resultMatrix);






