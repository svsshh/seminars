Console.WriteLine("54: Напишите программу, которая упорядочит "
+ "по убыванию элементы каждой строки двумерного массива.");

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine("------");
PrintArray(array);

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("56: Напишите программу, которая будет находить "
+ " строку с наименьшей суммой элементов двумерного массива.");

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"Меньшая сумма в строке {GetRowNumber (array)}");

int GetRowNumber (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("58. Напишите программу, которая будет находить произведение двух матриц.");
Console.Write("Количество строк A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество строк B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);

if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    Console.WriteLine();
    PrintArray(A);
    Console.WriteLine();
    PrintArray(B);
}
else
{
    PrintArray(A);
    Console.WriteLine();
    PrintArray(B);
    Console.WriteLine();
    PrintArray(GetUmnozh(A, B));
}

int[,] GetUmnozh(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
