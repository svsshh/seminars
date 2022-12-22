Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введи число: ");
string number = Console.ReadLine();
if (number.Length != 3)
{
    Console.WriteLine("Число должно быть трёхзначным");
}
else
{
    Console.WriteLine(number[1]);
}

Console.WriteLine("Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (до 100000)");
Console.Write("Введи число: ");
int a = int.Parse(Console.ReadLine());
string chislo = Convert.ToString(a);
if (chislo.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    Console.WriteLine(chislo[2]);
}

Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. (<1 и >7)");
Console.Write("Введи номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("Нужен номер дня с 1 по 7");
}
else 
{
    Console.WriteLine("Это будний день");
}