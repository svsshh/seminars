Console.WriteLine("25.1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введи A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {vstepen(A, B)}");

int vstepen(int num, int rank)
{
    if (rank == 0) return 1;
    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result = result * num;
    }
    return result;
}

// Console.WriteLine("25.2 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
// Console.Write("Введи A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int umnozh(int first, int second)
// {
//     int result = 1;
//     for (int i = 1; i <= second; i++)
//     {
//         result = result * first;
//     }
//     return result;
// }
// int otvet = umnozh(numA, numB);
// Console.WriteLine("Ответ: " + otvet);

Console.WriteLine("27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введи число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр: {summa(chislo)}");

int summa(int numer)
{
    int rslt = 0;
    while (numer > 0)
    {
        rslt = rslt + numer % 10;
        numer = numer / 10;
    }
    return rslt;
}
// int sum = summa(chislo);
// Console.WriteLine("Сумма цифр: " + sum); // !!! если убрать 42 строку

Console.WriteLine("29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
int[] array = GetRandomArray(8,50,1000);

Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(min,max);
    }
    return result;
}