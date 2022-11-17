// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа, после того как ввели, нажмите Enter: ");
int i = 0;
int[] array = new int[100];

while(i < array.Length)
{
    String input = Console.ReadLine();
    if(input == "")
    {
        break;
    }
    else array[i] = int.Parse(input);
    i++;
}


int CountPositive(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i] > 0) count++;
    }
    return count;
}
int count = CountPositive(array);

Console.Write($"Чисел больше 0 - {count}");