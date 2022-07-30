// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.WriteLine($"Эта программа которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

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
Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= row && position[1] <= col && position[0] >= 0 && position[1] >= 0) 

{
  double result = matrix[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}
