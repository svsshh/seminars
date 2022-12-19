Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("Введи первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num2 = int.Parse(Console.ReadLine());
if (num1 < num2)
    Console.WriteLine("Второе  - больше");
else
{
    Console.WriteLine("Первое - больше");
}

Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введи первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введи третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Больше всех");
Console.WriteLine(max); // правильнее было в одну строку Console.WriteLine($"Больше всех = {max}");

Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("Введи число");
int chislo = int.Parse(Console.ReadLine());
if (chislo % 2 == 0)
    Console.WriteLine("Четное");
else
{
    Console.WriteLine("Нечетное");
}

Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введи число");
int N = int.Parse(Console.ReadLine());
int start = 1;
while (start <= N)
{
    if (start % 2 == 0)
    {
        Console.WriteLine(start); // правильнее Console.WriteLine($"{start}");
    }
    start++;
}