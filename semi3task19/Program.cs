//Задача 19 Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Эта программа которая принимает на вход число и проверяет, является ли оно палиндромом.");
Console.Write("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int rev = 0;
while (number > 0)
    {
    int digital = number % 10;
    rev = rev * 10 + digital;
    number = number / 10;
    }

if(temp == rev)
    {
    Console.WriteLine( "полидром");
    }

else
    {
    Console.WriteLine("не полидром");
    }

// Здравствуйте попытался сделать чтобы определяло любой полидром (от любого количества чисел), вроде работает до 10 чисел (123456789). Но если больше то выдает такую ошибку.  Unhandled exception. System.OverflowException: Value was either too large or too small for an Int64.
//    at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
//    at System.Convert.ToInt64(String value)
//    at Program.<Main>$(String[] args) in C:\Users\nitro\Desktop\Гигбрейнс\C#\Homework\semi3task19\Program.cs:line 10
// PS C:\Users\nitro\Desktop\Гигбрейнс\C#\Homework\semi3task19> 
// как понимаю вопрос в конверте Convert.ToInt32(Console.ReadLine()); решаю вопрос)