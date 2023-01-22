Console.WriteLine("34. Задайте массив заполненный случайными положительными трёхзначными числами. " 
+ "Напишите программу, которая покажет количество чётных чисел в массиве.");
int[] nashmassiv = GetArray(6, 100, 1000);
Console.WriteLine(String.Join(" ", nashmassiv));
Console.WriteLine($"Количество четных: {GetChetnie(nashmassiv)}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int GetChetnie(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("36. Задайте одномерный массив, заполненный случайными числами. "
+ "Найдите сумму элементов, стоящих на нечётных индексах.");
int[] randomassiv = GetRando(7, 5, 55);
Console.WriteLine(String.Join(" ", randomassiv));
Console.WriteLine($"Сумма цифр на нечетных индексах: {GetNechetInd(randomassiv)}");

int[] GetRando(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int GetNechetInd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    // foreach (var i in array) //нельзя, потому что нам нужны индексы, а не элементы
    {
        if (i % 2 == 1) sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("37. Найдите произведение пар чисел в одномерном массиве. " 
+ "Парой считаем первый и последний элемент, второй и предпоследний и т.д. " 
+ "Результат запишите в новом массиве.");
int[] startArray = GetMassiv(7, 0, 9);

Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", ItogoArray(startArray)));

int[] GetMassiv(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int[] ItogoArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}