// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6\


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if((number >= 100)&&(number < 1000))
{
    int num1 = number  % 10;
    Console.WriteLine($"Третья цифра: {num1}");
}
if((number >= 1000)&&(number < 10000))
{
    int num1 = (number / 10)  % 10;
    Console.WriteLine($"Третья цифра: {num1}");
}
if((number >= 10000)&&(number < 100000))
{
    int num1 = (number / 100)  % 10;
    Console.WriteLine($"Третья цифра: {num1}");
}
if((number >= 100000)&&(number < 1000000))
{
    int num1 = (number / 1000)  % 10;
    Console.WriteLine($"Третья цифра: {num1}");
}
