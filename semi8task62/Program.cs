// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 01 02 03 04

// 12 13 14 05

// 11 16 15 06

// 10 09 08 07

Console.WriteLine($"Заполненый спиралью (по часовой) массив 4 на 4.");
int row = 4;
int col = 4;
int[,] array = new int[row, col];
FillMatrixRoundInt(row, col);
PrintMatrixInt(array);


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


int[,] FillMatrixRoundInt(int row, int col)

{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
    }
    return array;
}



