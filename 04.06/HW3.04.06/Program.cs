// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],3} ");
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

int[,] ProizvMatr(int[,] arr_first, int[,] arr_second)
{
    int row = arr_first.GetLength(0);
    int column = arr_first.GetLength(1);
    int[,] proizv_matr = new int[row, column];

    for (int i = 0; i < row; i++)       
        for (int j = 0; j < column; j++)
            proizv_matr[i, j] = arr_first[i, j] * arr_second[i, j];            
    return proizv_matr;
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Massive(row, column, 0, 5);
Print(arr_1);
int[,] arr_2 = Massive(row, column, 0, 5);
Print(arr_2);

int[,] result = ProizvMatr(arr_1, arr_2);
Print(result);