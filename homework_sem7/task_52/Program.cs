// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = new int[3, 4];

void FillArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 10);
            Console.Write(a[i, j] + "; ");
        }
        Console.WriteLine();
    }
}
void meanColumns(int[,] matr)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum = sum + matr[j, i];
        }
        double mean = sum / matr.GetLength(0);
        Console.Write(Math.Round(mean, 2) + "; ");
        sum = 0;
    }

}
FillArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
meanColumns(array);
