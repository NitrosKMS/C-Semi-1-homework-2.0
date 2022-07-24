// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.WriteLine($"Эта программа которая считает сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Введите количество чисел в массиве.");
int num = Convert.ToInt32(Console.ReadLine());

int[] massive = new int[num];

void InputNum(int num)

{
for (int i = 0; i < num; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massive)
{
  int count = 0;
  for (int i = 0; i < massive.Length; i++)
  {
    if (massive[i] > 0) count += 1; 
  }
  return count;
}

InputNum(num);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massive)} ");