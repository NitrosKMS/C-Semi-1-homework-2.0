﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine($"Эта программа которая показывает сумму нечётных чисел в массиве.");
Console.Write($"Введи количество элементов массива: ");
int Elements = Convert.ToInt32(Console.ReadLine()); 

int Random(int Elements, int min, int max)
  {
  int[] randoms = new int[Elements];
  int sumElements = 0;
  Console.Write("Массив: ");

    for (int i = 0; i <randoms.Length; i++ )
    {
      randoms[i] = new Random().Next(min, max);

      Console.Write(randoms[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randoms[i];
      }
    }
  return sumElements;
  }

int randomNums =  Random(Elements, -999, 999);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNums}");
