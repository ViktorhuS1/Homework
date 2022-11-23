// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] GetArray(int row, int col)
{
    int[,] matr = new int[row, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 30);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] multiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {

        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int z = 0; z < firstMatrix.GetLength(1); z++)
            {
                sum += firstMatrix[i, z] * secondMatrix[z, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

Console.Write("Введите количество строк матриц: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матриц: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] firstMatrix = GetArray(rows, columns);
int[,] secondMatrix = GetArray(rows, columns);
int[,] multMatrix = multiplyMatrix(firstMatrix, secondMatrix);

Console.WriteLine("\nПервая матрица: ");
PrintMatrix(firstMatrix);
Console.WriteLine("\nВторая матрица: ");
PrintMatrix(secondMatrix);
Console.WriteLine("\nРезультат: ");
PrintMatrix(multMatrix);
