// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[7];

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-50, 50);
    }
}

int SumOdd(int[] a)
{
    int sum = 0;
    for (int i = 1; i < a.Length; i += 2)
    {
        sum += a[i];
    }
    return sum;
}
FillArray(array);
Console.WriteLine(String.Join(", ", array));

int summa = SumOdd(array);
Console.WriteLine($"Сумма нечетных чисел равна {summa}");