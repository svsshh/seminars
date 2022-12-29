Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введи число: ");

string text = Console.ReadLine();
if (text.Length != 5)
{
    Console.WriteLine("Нужно пятизначное число!");
}
if (text.Length == 5)
{
    if (text[0] == text[4] && text[1] == text[3])
        Console.WriteLine("Это число - палиндром");
    else
        Console.WriteLine("Это число не палиндром");
}


Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.Write("Введи x точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)), 4);
Console.WriteLine($"Расстояние между двумя точками: {result}");


Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введи число: ");

int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}