// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Эта программа которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите число обозначающую день недели от 1 до 7.");

int num = Convert.ToInt32(Console.ReadLine());

string day = "     ";
if (num == 6 || num == 7)
{
    string weekend = "Выходной день";
    if (num == 6)

    {
        day = "Суббота";
    }

    else day = "Воскресенье";
    Console.Write($"{day} - {weekend}");
}
else
{
string workday = "Рабочий день";
if (num == 1)
{
    day = "Понедельник";
}
else if (num == 2)
{
    day = "Вторник";
}
else if (num == 3)
{
    day = "Среда";
}
else if (num == 4)
{
    day = "Четверг";
}
else 
day = "Пятница";
Console.Write($"{day} - {workday}");
}