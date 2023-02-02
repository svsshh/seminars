Console.WriteLine("46. Задайте двумерный массив размером m×n "
+ "заполненный случайными вещественными числами.");

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (max - min);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("50. Напишите программу, которая на вход принимает число, и проверяет "
+ "есть ли такое число в двумерном массиве, а также возвращает сообщение о том, "
+ "что оно найдено или же указание, что такого элемента нет");

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Ищем цифру...");
int element = Convert.ToInt32(Console.ReadLine());

if (FindElement(array, element))
{
    Console.WriteLine("Нашлась");
}
else
{
    Console.WriteLine("Такой цифры нет");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}

bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            if (array[i, j] == el) return true;
        }
    }
    return false;
}

Console.WriteLine("52. Задайте двумерный массив из целых чисел. Найдите среднее "
+ "арифметическое элементов в каждом столбце.");

Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];
FillArrayRandom(numbers);
PrintArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        average += numbers[i, j];
    }
    average = average / m;
    Console.Write(average + ", ");
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}