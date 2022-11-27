// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int FooAkk(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return FooAkk(m - 1, 1);
    if ((m > 0) && (n > 0)) return FooAkk(m - 1, FooAkk(m, n - 1));
    else return n + 1;
}

Console.WriteLine(FooAkk(num, num2));

