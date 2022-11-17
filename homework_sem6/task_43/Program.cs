// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Введите точку k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.Write("Введите точку b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите точку k2: ");
int k2 = int.Parse(Console.ReadLine());

Console.Write("Введите точку b2: ");
int b2 = int.Parse(Console.ReadLine());

double k3 = k1 - k2;
double b3 =  b2 - b1;
if(k3 < 0) 
{
    k3 = k3 * (-1);
    b3 = b3 * (-1);
}
double x = b3 / k3;
double y = k1 * x + b1;

Console.Write($"Точка пересечения: {x}; {y}");



