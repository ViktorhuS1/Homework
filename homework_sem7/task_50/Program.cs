// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());



int[,] matrix = new int[rows, columns];

void GetArray(int[,] a)

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
GetArray(matrix);
Console.Write("Введите номер строки: ");
int numRow = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int numColumn = int.Parse(Console.ReadLine());


if((numRow>rows)||(numColumn>columns))
{
    Console.Write("Такой позиции нет!");
    return;
}
else Console.WriteLine($"Ваш элемент: {matrix[numRow, numColumn]}");

