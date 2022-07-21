//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76 

Console.WriteLine($"Эта программа которая находит разницу между максимальным и минимальным элементов массива..");
Console.WriteLine("Введите количество вещественных чисел в массиве.");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];

{
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 999999999);  
    // Здравствуйте возник вопрос, почему рандом дает большие числа почти всегда? 
                                                
    // (обычно если ограничиваю например 9 значными цифрами то выдает всегда девятизначные числа)
    // и также если другое колличество, есть способ более красиво сделать или нужен другой способ?
    
  }
}


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i] + "]");
    }
}

double Maxnum(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double Minnum(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

Console.Write("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
double resMin = Minnum(array);
double resMax = Maxnum(array);
double res = resMax - resMin;
Console.Write($"Разница между максимальным и минимальным значениями массива: {res}");


