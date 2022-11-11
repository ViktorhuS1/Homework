// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());

double PowerNum(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}
double pow = PowerNum(a, b);
Console.Write($"Число {a} в {b} степени равно {pow}");
