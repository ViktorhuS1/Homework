// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int third_number = Convert.ToInt32(Console.ReadLine());


if(first_number >= second_number)
{
    if(first_number > third_number)
    {
        Console.Write("Максимальное число: ");
        Console.Write(first_number);
    }
}
if(second_number > first_number)
{
    if(second_number > third_number)
    {
        Console.Write("Максимальное число: ");
        Console.Write(second_number);
    }
}
if(third_number >= first_number)
{
    if(third_number >= second_number)
    {
        Console.Write("Максимальное число: ");
        Console.Write(third_number);
    }
}


