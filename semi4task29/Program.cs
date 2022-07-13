// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine($"Массив из 8 элементов:");
int[] array = new int[8];
Random rnd = new Random();
PrintMassiv(array);
PrintArr(array);

void PrintMassiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)

    {
        arr[i] = rnd.Next();
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i] + "]");
        }
    }
}



















