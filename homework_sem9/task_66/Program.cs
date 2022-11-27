// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int summa = 0;

int sumNumbers(int firstNum, int lastNum)
{
    if (firstNum == lastNum) return summa + lastNum;
    return summa = summa + (firstNum + sumNumbers(firstNum + 1, lastNum));
}

Console.WriteLine(sumNumbers(num, num2));
