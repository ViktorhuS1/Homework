﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] array = new double[3, 4];

void FillArray(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
            a[i, j] = Math.Round(a[i, j], 1);
        }
    }
}

void PrintArray(double [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]}; ");
        }
    }
}
FillArray(array);
PrintArray(array);
