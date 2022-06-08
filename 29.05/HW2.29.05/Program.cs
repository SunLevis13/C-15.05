// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
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

string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    string text = "";

    if (f > row || f <= 0 || s > column || s <= 0)
        text = $"{f} {s} -> not in the array";

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (i + 1 == f && j + 1 == s)
            {
                text = $"arr[{f}, {s}] = {arr[i, j]} -> is in the array";
                break;
            }
    return text;
}

Console.Write("Enter the line position: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine());

int[,] arr_1 = Massive(3, 6, 4, 11);
Print(arr_1);

Console.WriteLine(FindElement(arr_1, first, second));
