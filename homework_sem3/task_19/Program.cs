﻿// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

if(num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine("Это число является палиндромом");
}
else if(num[0] == num[4])
{
    Console.WriteLine("Это число НЕ палиндром");
}
else
{
    Console.Write("Введите пятизначное! число: ");
}