// Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
void Print(int[,] arr)
{
    int row= arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray (int [,] arr, int from, int to)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(from, to);
                }
    }
}

int[] FindArray(int [,] matr)
{
    int min = matr[0,0];
    int[] arr = new int[2];
   for (int i = 0; i < matr.GetLength(0); i++)
        {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]< min)
            {
                min = matr[i,j];
                arr[0] = i;
                arr[1] = j;
            }
        }
        }
        Console.WriteLine(min);
        return arr;
}



int[,] matrix = new int [4,4];
FillArray(matrix, -10,10);
Print(matrix);
Console.WriteLine();
FindArray(matrix);
Print(matrix);