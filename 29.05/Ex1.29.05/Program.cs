// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }        
    }
    return arr;
}

Console.Write("Введите количество строк row: ");
int row = int.Parse (Console.ReadLine());

Console.Write("Введите количество столбцов column: ");
int column = int.Parse (Console.ReadLine());

Print(MassNums(row,column,10,21));
