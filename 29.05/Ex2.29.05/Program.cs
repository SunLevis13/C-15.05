// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n
// Выведите полученный массив на экран.

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
}

void FillArray (int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {   
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = i + j;
        }        
    }
}

int[,] matrix = new int[3,4];
FillArray(matrix);
PrintArray(matrix);