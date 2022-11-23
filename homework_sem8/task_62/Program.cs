// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];

int row = matrix.GetLength(0);
int col = matrix.GetLength(1);

for (int i = 0; i < row; i++)
{
    matrix[0, i] = i + 1;
}
for (int i = 0; i < col - 1; i++)
{
    matrix[i + 1, col - 1] = matrix[i, row - 1] + 1;
}
for (int i = 0; i < row - 1; i++)
{
    matrix[row - 1, col - 2 - i] = matrix[row - 1, col - 1 - i] + 1;
}
for (int i = 0; i < row - 2; i++)
{
    matrix[row - 2 - i, 0] = matrix[row - 1, col - 2 - i] + 3;
}
for (int i = 0; i < col - 2; i++)
{
    matrix[1, i + 1] = matrix[1, i] + 1;
}
for (int i = 0; i < col - 2; i++)
{
    matrix[2, col - 2 - i] = matrix[i + 1, col - 2] + 1;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] < 10) Console.Write($"0{matr[i,j]}; ");
            else Console.Write($"{matr[i,j]}; ");
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);