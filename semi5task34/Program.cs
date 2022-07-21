// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine($"Эта программа которая показывает количество чётных чисел в массиве.");
Console.WriteLine("Введите количество чисел в массиве.");
int num = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[num];

void FillArray(int[] array, int min, int max)

{
  for (int i = 0; i < array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)

{
    for (int i = 0; i < array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array)

{
    int even = 0;
    for (int i = 0; i < array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      even++;
    }
  }
  return even;
}

FillArray(numbers, 100, 999);
WriteArray(numbers);
Console.WriteLine();

int even = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {even}");