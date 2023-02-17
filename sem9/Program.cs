Console.WriteLine("64. Задайте значение N. Напишите программу, "
+ "которая выведет все натуральные числа в промежутке от N до 1.");
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(N, 1));

string PrintNumbers(int end, int start)
{
    if (end == start) return Convert.ToString(end);
    return (end + " " + PrintNumbers(end - 1, start));
}

Console.WriteLine("66: Задайте значения M и N. Напишите программу, "
+ "которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел между {M} и {N} = {Summa(M, N)}");

int Summa(int a, int b)
{
    if (a <= b)
        if (a == b)
            return a;
    return a + Summa(a + 1, b);
    if (a >= b)
        if (a == b)
            return b;
    return b + Summa(a, b + 1);
}

// Console.WriteLine("68: Напишите программу вычисления функции Аккермана "
// + "с помощью рекурсии. Даны два неотрицательных числа m и n.");
// Console.Write("Введи m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи n: ");
// int n = Convert.ToInt32(Console.ReadLine());
