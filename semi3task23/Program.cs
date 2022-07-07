// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Это которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N..");
Console.Write("Введите число ");
double number = Convert.ToInt32(Console.ReadLine());

double count = 1;
double three = 0;

if (number < 0)
{
     while (count >= number)
    
    {
        three = count * count * count;
        Console.WriteLine($"{count,3} -> {three,5}");
        count--;
     }
}
 else 
{    
     while (count <= number)
    
    {
        three = count * count * count;
        Console.WriteLine($"{count,3} -> {three,5}");
        count++;
    }
}


//Здравствуйте, пробовал через Math.Pow почемуто не делает столбцом, не подскажите в чем ошибка? Так понял можно сделать чтобы в любую степень любое число возводил.
// if (number < 0)
// {
//    while (count >= number)
    
//   {
//       pow = Math.Pow(number,3);
      
//       Console.WriteLine($"{number,3} -> {pow,5}");
//       count--;
//   }
// }
// else 
// {    
       
//        while (count <= number)
// {
//         pow = Math.Pow(number,3);
        
//         Console.WriteLine($"{count,3} -> {pow,5}");

//         count++;
// }
// }




