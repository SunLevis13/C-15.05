// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j], 6} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] array = new double[row, column];
    Random nums = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = Math.Round(nums.NextDouble() * -10, 2);            
    return array;
}


double[,] array = MassNums(3, 5, -8, 6);
Print(array);


