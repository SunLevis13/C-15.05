﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Massive(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void Average(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double result;

    for (int i = 0; i < column; i++)
    {
        result = 0;
        for (int j = 0; j < row; j++) result += arr[j, i];
        Console.Write($"{Math.Round(result / row, 2)}; ");
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Massive(row, column, 1, 9);
Print(arr_1);

Average(arr_1);
