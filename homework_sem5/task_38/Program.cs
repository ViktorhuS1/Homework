// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[5];

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 100);
    }
}

int MinMax(int[] a)
{
    int min = a[0];
    int max = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i] < min) min = a[i];
        if(a[i] > max) max = a[i];
    }
    int result = max - min;
    return result;
}
FillArray(array);
int dif = MinMax(array);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между мин и макс {dif}");