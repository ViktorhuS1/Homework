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

int max = first_number;
if(first_number > max) max = first_number;
if(second_number > max) max = second_number;
if(third_number > max) max = third_number;
Console.WriteLine("Максимальное число: ");
Console.Write(max);

